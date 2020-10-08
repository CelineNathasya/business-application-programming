using Entitas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFileAccessWinForms
{
   public partial class Form3 : Form
   {
      public Form3()
      {
         InitializeComponent();
         this.dgvData.AutoGenerateColumns = false;
      }

      string _namaFile = @".\..\..\sampleJSON.txt";

      bool _editMode = false;

      List<Mahasiswa> _listData = default;

      BindingSource bs = null;

      private List<Mahasiswa> LoadDataFromFile(string namafile)
      {
         List<Mahasiswa> listData = null;
         if (File.Exists(namafile))
         {
            try
            {
               string fileContent = File.ReadAllText(namafile);
               if (fileContent.Length > 0)
               {
                  listData = JsonConvert.DeserializeObject<List<Mahasiswa>>(fileContent);
               }
            }
            catch (Exception)
            {
               throw;
            }
         }
         return listData;
      }

      private bool WriteToFile(IEnumerable<Mahasiswa> listData)
      {
         try
         {
            if (listData != null && listData.Any())
            {
               string jsonString = JsonConvert.SerializeObject(listData, Formatting.Indented);
               File.WriteAllText(_namaFile, jsonString);
               return true;
            }
         }
         catch (Exception)
         {
            throw;
         }
         return false;
      }

      private void ClearForm()
      {
         foreach (Control item in this.grpItemData.Controls)
         {
            if (item is TextBox txt)
            {
               txt.Clear();
            }
            else if (item is ComboBox cbo)
            {
               cbo.Text = "";
            }
         }
      }

      private void Form3_Load(object sender, EventArgs e)
      {
         try
         {
            _listData = LoadDataFromFile(_namaFile);
            bs = new BindingSource();
            bs.DataSource = _listData;
            this.dgvData.DataSource = bs;
            this.dgvData.Columns[0].DataPropertyName = nameof(Mahasiswa.Nim);
            this.dgvData.Columns[1].DataPropertyName = nameof(Mahasiswa.Nama);
            this.dgvData.Columns[2].DataPropertyName = nameof(Mahasiswa.TempatLahir);
            this.dgvData.Columns[3].DataPropertyName = nameof(Mahasiswa.TanggalLahir);
            this.dgvData.Columns[4].DataPropertyName = nameof(Mahasiswa.WaktuKuliah);
            this.dgvData.Columns[5].DataPropertyName = nameof(Mahasiswa.Kelas);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void Form3_Resize(object sender, EventArgs e)
      {
         foreach (DataGridViewColumn column in this.dgvData.Columns)
         {
            if (column.HeaderText.Equals("nama", StringComparison.CurrentCultureIgnoreCase))
            {
               column.Width = 30 * this.dgvData.Width / 100;
            }
            else if (column.HeaderText.Equals("tmpt. lahir", StringComparison.CurrentCultureIgnoreCase))
            {
               column.Width = 20 * this.dgvData.Width / 100;
            }
            else if (column.HeaderText.Equals("nim", StringComparison.CurrentCultureIgnoreCase) || column.HeaderText.Equals("tgl. lahir", StringComparison.CurrentCultureIgnoreCase))
            {
               column.Width = 12 * this.dgvData.Width / 100;
            }
         }
      }

      private void txtNim_Enter(object sender, EventArgs e)
      {
         Control ctl = sender as Control;
         ctl.BackColor = Color.FromKnownColor(KnownColor.LightCyan);
      }

      private void txtNim_Leave(object sender, EventArgs e)
      {
         Control ctl = sender as Control;
         ctl.BackColor = Color.FromKnownColor(KnownColor.Window);
         if (ctl.Name.Equals("txtTanggalLahir") && ctl.Text.Trim() != string.Empty)
         {
            string strTanggal = ctl.Text.Replace('.', '/');
            if (DateTime.TryParse(strTanggal, out DateTime tgl))
            {
               ctl.Text = tgl.ToString("dd/MM/yyyy");
            }
            else
            {
               MessageBox.Show("Sorry, data tanggal lahir tidak valid ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               this.txtTanggalLahir.Clear();
               this.txtTanggalLahir.Focus();
            }
         }
      }

      private void txtNim_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private void txtTanggalLahir_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = true;
         if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '/' || e.KeyChar == '.') e.Handled = false;
      }

      private bool DataMahasiswaSudahAda(string nim)
      {
         return _listData.Where(item => item.Nim.Equals(nim, StringComparison.CurrentCultureIgnoreCase)).Count() > 0;
      }

      private void btnSimpan_Click(object sender, EventArgs e)
      {
         if (this.txtNim.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data nim tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNim.Focus();
         }
         else if (this.txtNama.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data nama tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNama.Focus();
         }
         else if (this.txtTempatLahir.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data tempat lahir tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtTempatLahir.Focus();
         }
         else if (this.txtTanggalLahir.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data tanggal lahir tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtTanggalLahir.Focus();
         }
         else if (this.cboWaktuKuliah.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data waktu kuliah tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.cboWaktuKuliah.Focus();
         }
         else if (this.cboKelas.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, data kelas tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.cboKelas.Focus();
         }
         else
         {
            try
            {
               Mahasiswa mahasiswaBaru = new Mahasiswa(this.txtNim.Text.Trim(), this.txtNama.Text.Trim(), this.txtTempatLahir.Text.Trim(), this.txtTanggalLahir.Text.Trim(), this.cboWaktuKuliah.Text.Trim(), this.cboKelas.Text.Trim());
               if (!_editMode)
               {
                  if (DataMahasiswaSudahAda(mahasiswaBaru.Nim))
                  {
                     throw new Exception("Sorry, data mahasiswa dengan nim yang sama sudah ada ...");
                  }
                  _listData.Add(mahasiswaBaru);
               }
               else
               {
                  // edit mode
                  Mahasiswa mhs =
                     _listData
                     .Where(item => item.Nim.Equals(this.txtNim.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                     .Select(item => item)
                     .FirstOrDefault();
                  if (mhs != null)
                  {
                     mhs.Nama = this.txtNama.Text.Trim();
                     mhs.TempatLahir = this.txtTempatLahir.Text.Trim();
                     mhs.TanggalLahir = Convert.ToDateTime(this.txtTanggalLahir.Text).Date;
                     mhs.WaktuKuliah = this.cboWaktuKuliah.Text;
                     mhs.Kelas = this.cboKelas.Text;
                  }
               }
               WriteToFile(_listData);
               bs.ResetBindings(false);
               this.btnBatal_Click(null, null);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }

      private void btnBatal_Click(object sender, EventArgs e)
      {
         this.txtNim.Enabled = true;
         _editMode = false;
         ClearForm();
      }

      private void editToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            DataGridViewRow currRow = this.dgvData.CurrentRow;
            string nim = currRow.Cells[0].Value.ToString();
            string nama = currRow.Cells[1].Value.ToString();
            string tempatLahir = currRow.Cells[2].Value.ToString();
            string tanggalLahir = currRow.Cells[3].Value.ToString();
            string waktuKuliah = currRow.Cells[4].Value.ToString();
            string kelas = currRow.Cells[5].Value.ToString();
            if (MessageBox.Show($"Edit Item Data Mahasiswa Nim: {nim}, Nama: {nama} ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               this.txtNim.Text = nim;
               this.txtNama.Text = nama;
               this.txtTempatLahir.Text = tempatLahir;
               this.txtTanggalLahir.Text = Convert.ToDateTime(tanggalLahir).ToString("dd/MM/yyyy");
               this.cboWaktuKuliah.Text = waktuKuliah;
               this.cboKelas.Text = kelas;
               this.txtNim.Enabled = false;
               _editMode = true;
            }
         }
      }

      private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            DataGridViewRow currRow = this.dgvData.CurrentRow;
            string nim = currRow.Cells[0].Value.ToString().Trim();
            string nama = currRow.Cells[1].Value.ToString().Trim();
            if (MessageBox.Show($"Hapus Item Data Mahasiswa Nim: {nim}, Nama: {nama} ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               try
               {
                  int index = _listData.FindIndex(mhs => mhs.Nim.Equals(nim, StringComparison.CurrentCultureIgnoreCase));
                  if (index >= 0)
                  {
                     Mahasiswa mhs = _listData[index];
                     if (_listData.Remove(mhs))
                     {
                        bs.ResetBindings(false);
                        WriteToFile(_listData);
                        MessageBox.Show($"Hapus Item Data Mahasiswa Nim: {nim}, Nama: {nama} Sukses.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                  }
               }
               catch (Exception ex)
               {
                  MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
         }
      }

   }
}
