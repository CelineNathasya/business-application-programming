using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class FrmAddressBook2 : Form
   {

      int _no = default;
      bool _editMode = false;

      System.Timers.Timer timer = default;

      string _connString = @"Server=.\sql2019express;database=db_addressbook;Trusted_Connection=true";

      public FrmAddressBook2()
      {
         InitializeComponent();
         this.lblHariTanggalDanWaktu.Text = $"{DateTime.Now:dddd, dd MMMM yyyy - HH:mm:ss}";
         timer = new System.Timers.Timer(1000);
         timer.Elapsed += Timer_Elapsed;
         timer.Start();
      }

      private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
      {
         this.lblHariTanggalDanWaktu.Text = $"{DateTime.Now:dddd, dd MMMM yyyy - HH:mm:ss}";
      }

      private void QueryData(string namaQuery = "")
      {
         try
         {
            this.dgvData.Rows.Clear();
            using (var conn = new SqlConnection(_connString))
            {
               conn.Open();
               using (var cmd = new SqlCommand("select * from addressbook where deleted = 0 and nama like @nama order by no", conn))
               {
                  cmd.Parameters.Clear();
                  cmd.Parameters.AddWithValue("@nama", $"{namaQuery}%");
                  using (var reader = cmd.ExecuteReader())
                  {
                     if (reader.HasRows)
                     {
                        while (reader.Read())
                        {
                           string no = reader["no"].ToString();
                           string nama = reader["nama"].ToString();
                           string alamat = reader["alamat"].ToString();
                           string kota = reader["kota"].ToString();
                           string kodePos = reader["kodepos"].ToString();
                           string nomorHP = reader["nomorhp"].ToString();
                           string keterangan = reader["keterangan"].ToString();
                           string picture = reader["picture"].ToString();
                           string createdDate = reader["createddate"].ToString();
                           string updatedDate = reader["updateddate"].ToString();
                           this.dgvData.Rows.Add(new string[] { no, nama, alamat, kota, kodePos, nomorHP, keterangan, createdDate, updatedDate, picture });
                        }
                     }
                  }
               }
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

      private void FrmAddressBook2_Load(object sender, EventArgs e)
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
            SqlConnection conn = default;
            SqlTransaction trans = default;
            try
            {
               conn = new SqlConnection(_connString);
               conn.Open();
               trans = conn.BeginTransaction();
               using (var cmd = new SqlCommand())
               {
                  cmd.Connection = conn;
                  cmd.Transaction = trans;
                  if (!_editMode)
                  {
                     cmd.CommandText =
                        @"insert into addressbook (nama, alamat, kota, kodepos, nomorhp, keterangan, picture, createddate) 
                           values (@nama, @alamat, @kota, @kodepos, @nomorhp, @keterangan, @picture, @createddate)";
                     cmd.Parameters.Clear();
                     cmd.Parameters.AddWithValue("@nama", this.txtNama.Text.Trim());
                     cmd.Parameters.AddWithValue("@alamat", this.txtAlamat.Text.Trim());
                     cmd.Parameters.AddWithValue("@kota", this.txtKota.Text.Trim());
                     cmd.Parameters.AddWithValue("@kodepos", this.txtKodePos.Text.Trim());
                     cmd.Parameters.AddWithValue("@nomorhp", this.txtNomorHP.Text.Trim());
                     cmd.Parameters.AddWithValue("@keterangan", this.txtKeterangan.Text.Trim());
                     cmd.Parameters.AddWithValue("@picture", this.pictBox.Tag?.ToString() ?? "");
                     cmd.Parameters.AddWithValue("@createddate", DateTime.Now);
                  }
                  else
                  {
                     // edit mode
                     cmd.CommandText =
                        @"update addressbook set nama = @nama, alamat = @alamat, kota = @kota, kodepos = @kodepos, nomorhp = @nomorhp, 
                           keterangan = @keterangan, picture = @picture, updateddate = @updateddate where no = @no";
                     cmd.Parameters.Clear();
                     cmd.Parameters.AddWithValue("@no", _no);
                     cmd.Parameters.AddWithValue("@nama", this.txtNama.Text.Trim());
                     cmd.Parameters.AddWithValue("@alamat", this.txtAlamat.Text.Trim());
                     cmd.Parameters.AddWithValue("@kota", this.txtKota.Text.Trim());
                     cmd.Parameters.AddWithValue("@kodepos", this.txtKodePos.Text.Trim());
                     cmd.Parameters.AddWithValue("@nomorhp", this.txtNomorHP.Text.Trim());
                     cmd.Parameters.AddWithValue("@keterangan", this.txtKeterangan.Text.Trim());
                     cmd.Parameters.AddWithValue("@picture", this.pictBox.Tag?.ToString() ?? "");
                     cmd.Parameters.AddWithValue("@updateddate", DateTime.Now);
                  }
                  cmd.ExecuteNonQuery();
               }
               trans.Commit();
               this.btnBatal_Click(null, null);
               QueryData(this.txtNamaQuery.Text.Trim());
            }
            catch (Exception ex)
            {
               if (trans != null) trans.Rollback();
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
               if (trans != null) trans.Dispose();
               if (conn != null) conn.Close();
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

      private void pictBox_DoubleClick(object sender, EventArgs e)
      {
         this.loadToolStripMenuItem_Click(null, null);
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.pictBox.Image = null;
         this.pictBox.Tag = null;
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
               SqlConnection conn = default;
               SqlTransaction trans = default;
               try
               {
                  conn = new SqlConnection(_connString);
                  conn.Open();
                  trans = conn.BeginTransaction();
                  using (var cmd = new SqlCommand())
                  {
                     cmd.Connection = conn;
                     cmd.Transaction = trans;
                     cmd.CommandText = @"update addressbook set deleted = 1 where no = @no";
                     cmd.Parameters.Clear();
                     cmd.Parameters.AddWithValue("@no", no);
                     cmd.ExecuteNonQuery();
                  }
                  trans.Commit();
                  this.btnBatal_Click(null, null);
                  QueryData(this.txtNamaQuery.Text.Trim());
               }
               catch (Exception ex)
               {
                  if (trans != null) trans.Rollback();
                  MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               finally
               {
                  if (trans != null) trans.Dispose();
                  if (conn != null) conn.Close();
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
