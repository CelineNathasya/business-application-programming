using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entitas;

namespace SampleFileAccessWinForms
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      string _namaFile = @".\..\..\sample.txt";

      bool _editMode = false;

      private void LoadDataFromFile()
      {
         this.dgvData.Rows.Clear();
         if (File.Exists(_namaFile))
         {
            try
            {
               string[] fileContent = File.ReadAllLines(_namaFile);
               if (fileContent.Length > 0)
               {
                  List<DataGridViewRow> rows = new List<DataGridViewRow>();
                  foreach (string line in fileContent.Skip(1))
                  {
                     string[] arrline = line.Split(';');
                     string nim = arrline[0].Trim();
                     string nama = arrline[1].Trim();
                     string tempatLahir = arrline[2].Trim();
                     string tanggalLahir = arrline[3].Trim();
                     string waktuKuliah = arrline[4].Trim();
                     string kelas = arrline[5].Trim();
                     DataGridViewRow newRow = new DataGridViewRow();
                     newRow.CreateCells(this.dgvData);
                     newRow.Cells[0].Value = nim;
                     newRow.Cells[1].Value = nama;
                     newRow.Cells[2].Value = tempatLahir;
                     newRow.Cells[3].Value = tanggalLahir;
                     newRow.Cells[4].Value = waktuKuliah;
                     newRow.Cells[5].Value = kelas;
                     rows.Add(newRow);
                  }
                  this.dgvData.Rows.AddRange(rows.ToArray());
               }
            }
            catch (Exception)
            {
               throw;
            }
         }
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

      private void Form1_Load(object sender, EventArgs e)
      {
         try
         {
            LoadDataFromFile();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void Form1_Resize(object sender, EventArgs e)
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
         foreach (DataGridViewRow row in this.dgvData.Rows)
         {
            if (row.Cells[0].Value.ToString().Trim().Equals(nim, StringComparison.CurrentCultureIgnoreCase))
            {
               return true;
            }
         }
         return false;
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
               string newLine = $"{this.txtNim.Text.Trim()};{this.txtNama.Text.Trim()};{this.txtTempatLahir.Text.Trim()};{this.txtTanggalLahir.Text};{this.cboWaktuKuliah.Text};{this.cboKelas.Text}";
               if (!_editMode)
               {
                  if (DataMahasiswaSudahAda(this.txtNim.Text.Trim()))
                  {
                     throw new Exception("Sorry, data mahasiswa dengan nim yang sama sudah ada ...");
                  }
                  File.AppendAllLines(_namaFile, new string[] { newLine });
               }
               else
               {
                  // edit mode
                  StringBuilder sb = new StringBuilder();
                  string[] fileContent = File.ReadAllLines(_namaFile);
                  string header = fileContent[0];
                  sb.AppendLine(header);
                  foreach (string line in fileContent.Skip(1))
                  {
                     if (!line.StartsWith(this.txtNim.Text.Trim()))
                     {
                        sb.AppendLine(line);
                     }
                     else
                     {
                        sb.AppendLine(newLine);
                     }
                  }
                  File.WriteAllText(_namaFile, sb.ToString());
               }
               LoadDataFromFile();
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

      private bool HapusItemDataFromFile(string nim)
      {
         try
         {
            StringBuilder sb = new StringBuilder();
            string[] fileContent = File.ReadAllLines(_namaFile);
            string header = fileContent[0];
            sb.AppendLine(header);
            foreach (string line in fileContent.Skip(1))
            {
               if (!line.StartsWith(nim))
               {
                  sb.AppendLine(line);
               }
            }
            File.WriteAllText(_namaFile, sb.ToString());
            return true;
         }
         catch (Exception)
         {
            throw;
         }
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
               this.txtTanggalLahir.Text = tanggalLahir;
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
                  if (HapusItemDataFromFile(nim))
                  {
                     LoadDataFromFile();
                     MessageBox.Show($"Hapus Item Data Mahasiswa Nim: {nim}, Nama: {nama} Sukses.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
