using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class FrmAddressBook5 : Form
   {

      int _no = default;
      bool _editMode = false;

      System.Timers.Timer timer = default;

      public FrmAddressBook5()
      {
         InitializeComponent();
         this.dgvData.AutoGenerateColumns = false;
         this.lblHariTanggalDanWaktu.Text = $"{DateTime.Now:dddd, dd MMMM yyyy - HH:mm:ss}";
         timer = new System.Timers.Timer(1000);
         timer.Elapsed += Timer_Elapsed;
         timer.Start();
      }

      private void Timer_Elapsed(object sender, ElapsedEventArgs e)
      {
         this.lblHariTanggalDanWaktu.Text = $"{DateTime.Now:dddd, dd MMMM yyyy - HH:mm:ss}";
      }

      private void QueryData(string namaQuery = "")
      {
         try
         {
            this.dgvData.DataSource = null;
            IEnumerable<AddressBook> listData = null;
            using (DALAddressBookDapper dal = new DALAddressBookDapper())
            {
               listData = dal.QueryData(namaQuery);
            }
            if (listData != null && listData.Count() > 0)
            {
               this.dgvData.DataSource = listData;
               this.dgvData.Columns[0].DataPropertyName = nameof(AddressBook.No);
               this.dgvData.Columns[1].DataPropertyName = nameof(AddressBook.Nama);
               this.dgvData.Columns[2].DataPropertyName = nameof(AddressBook.Alamat);
               this.dgvData.Columns[3].DataPropertyName = nameof(AddressBook.Kota);
               this.dgvData.Columns[4].DataPropertyName = nameof(AddressBook.KodePos);
               this.dgvData.Columns[5].DataPropertyName = nameof(AddressBook.NomorHP);
               this.dgvData.Columns[6].DataPropertyName = nameof(AddressBook.Keterangan);
               this.dgvData.Columns[7].DataPropertyName = nameof(AddressBook.CreatedDate);
               this.dgvData.Columns[8].DataPropertyName = nameof(AddressBook.UpdatedDate);
               this.dgvData.Columns[9].DataPropertyName = nameof(AddressBook.Picture);
            }
         }
         catch (Exception)
         {
            throw;
         }
         finally
         {
            this.dgvData_SelectionChanged(null, null);
         }
      }

      private void dgvData_SelectionChanged(object sender, EventArgs e)
      {
         try
         {
            this.pictBox.Image = null;
            if (this.dgvData.CurrentRow != null)
            {
               string pictPath = this.dgvData.CurrentRow.Cells[9].Value.ToString();
               //this.pictBox.Image = Image.FromFile(pictPath);
               //using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(pictPath)))
               //{
               //   this.pictBox.Image = Image.FromStream(ms);
               //}
               this.pictBox.Load(pictPath);
            }
         }
         catch (Exception)
         {
         }
      }

      private void FrmAddressBook5_Load(object sender, EventArgs e)
      {
         try
         {
            QueryData();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void txtNama_Enter(object sender, EventArgs e)
      {
         var control = sender as Control;
         control.BackColor = Color.FromKnownColor(KnownColor.LightCyan);
      }

      private void txtNama_Leave(object sender, EventArgs e)
      {
         var control = sender as Control;
         control.BackColor = Color.FromKnownColor(KnownColor.Window);
      }

      private void txtKodePos_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = true;
         if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
      }

      private void txtNomorHP_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = true;
         if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '(' || e.KeyChar == ')') e.Handled = false;
      }

      private void txtNama_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private void txtNamaQuery_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) this.btnFilter_Click(null, null);
      }

      private void btnSimpan_Click(object sender, EventArgs e)
      {
         if (this.txtNama.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data nama tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNama.Focus();
         }
         else if (this.txtAlamat.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data alamat tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtAlamat.Focus();
         }
         else if (this.txtKota.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data kota tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtKota.Focus();
         }
         else if (this.txtNomorHP.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data nomor hp tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNomorHP.Focus();
         }
         else
         {
            AddressBook itemData = new AddressBook
            {
               Nama = this.txtNama.Text.Trim(),
               Alamat = this.txtAlamat.Text.Trim(),
               Kota = this.txtKota.Text.Trim(),
               KodePos = this.txtKodePos.Text.Trim(),
               NomorHP = this.txtNomorHP.Text.Trim(),
               Keterangan = this.txtKeterangan.Text.Trim(),
               Picture = this.pictBox.Tag?.ToString() ?? "",
               CreatedDate = DateTime.Now,
               UpdatedDate = DateTime.Now
            };
            try
            {
               using (DALAddressBookDapper dal = new DALAddressBookDapper())
               {
                  if (!_editMode)
                  {
                     // create new
                     dal.Save(itemData);
                  }
                  else
                  {
                     // update
                     itemData.No = _no;
                     dal.Update(itemData);
                  }
               }
               this.btnBatal_Click(null, null);
               QueryData(this.txtNamaQuery.Text.Trim());
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private void btnBatal_Click(object sender, EventArgs e)
      {
         foreach (Control control in this.grpData.Controls)
         {
            if (control is TextBox txt) txt.Clear();
         }
         this.pictBox.Image = null;
         this.pictBox.Tag = null;
         _no = default;
         _editMode = false;
         this.dgvData_SelectionChanged(null, null);
         this.txtNama.Focus();
      }

      private void btnFilter_Click(object sender, EventArgs e)
      {
         try
         {
            QueryData(this.txtNamaQuery.Text.Trim());
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void loadToolStripMenuItem_Click(object sender, EventArgs e)
      {
         try
         {
            using (var ofd = new OpenFileDialog())
            {
               ofd.Title = "Pilih Foto";
               ofd.Filter = "JPG File (*.jpg)|*.jpg|PNG File (*.png)|*.png";
               ofd.FilterIndex = 0;
               ofd.CheckPathExists = true;
               ofd.CheckFileExists = true;
               ofd.Multiselect = false;
               ofd.FileName = "";
               if (ofd.ShowDialog() == DialogResult.OK)
               {
                  //this.pictBox.Image = Image.FromFile(ofd.FileName);
                  //using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(ofd.FileName)))
                  //{
                  //   this.pictBox.Image = Image.FromStream(ms);
                  //}
                  this.pictBox.Load(ofd.FileName);
                  this.pictBox.Tag = ofd.FileName;
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.pictBox.Image = null;
         this.pictBox.Tag = null;
      }

      private void pictBox_DoubleClick(object sender, EventArgs e)
      {
         this.loadToolStripMenuItem_Click(null, null);
      }

      private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            if (MessageBox.Show("Edit Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               DataGridViewRow row = this.dgvData.CurrentRow;
               this.txtNama.Text = row.Cells[1].Value.ToString();
               this.txtAlamat.Text = row.Cells[2].Value.ToString();
               this.txtKota.Text = row.Cells[3].Value.ToString();
               this.txtKodePos.Text = row.Cells[4].Value.ToString();
               this.txtNomorHP.Text = row.Cells[5].Value.ToString();
               this.txtKeterangan.Text = row.Cells[6].Value.ToString();
               this.pictBox.Tag = row.Cells[9].Value.ToString();
               if (this.pictBox.Tag?.ToString() != "") this.pictBox.Load(this.pictBox.Tag.ToString());
               _no = Convert.ToInt32(row.Cells[0].Value);
               _editMode = true;
            }
         }
      }

      private void hapusDataToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            if (MessageBox.Show("Hapus Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int no = Convert.ToInt32(this.dgvData.CurrentRow.Cells[0].Value);
               try
               {
                  using (DALAddressBookDapper dal = new DALAddressBookDapper())
                  {
                     dal.Delete(no);
                  }
                  this.btnBatal_Click(null, null);
                  QueryData(this.txtNamaQuery.Text.Trim());
               }
               catch (Exception ex)
               {
                  MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
         }
      }

      private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         this.editDataToolStripMenuItem_Click(null, null);
      }

   }
}
