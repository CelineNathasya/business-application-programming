using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomunikasiAntarFormWinFormSampleApp
{
   public partial class FrmTambahData : Form
   {

      private Mahasiswa _objMhs = null;

      private (string nim, string nama) _tupMhs = ("", "");

      public Mahasiswa RunAndReturnObjectMahasiswa(FrmTambahData form)
      {
         form.ShowDialog();
         return _objMhs;
      }

      public (string nim, string nama) RunAndReturnTupleMahasiswa(FrmTambahData form)
      {
         form.ShowDialog();
         return _tupMhs;
      }

      public FrmTambahData()
      {
         InitializeComponent();
      }

      private void txtNim_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private void FrmTambahData_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Escape) this.Close();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (this.txtNim.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, nim tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNim.Focus();
         }
         else if (this.txtNama.Text.Trim() == "")
         {
            MessageBox.Show("Sorry, nama tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtNama.Focus();
         }
         else
         {
            _objMhs = new Mahasiswa { Nim = this.txtNim.Text.Trim(), Nama = this.txtNama.Text.Trim() };
            _tupMhs = (this.txtNim.Text.Trim(), this.txtNama.Text.Trim());
            this.Close();
         }
      }

   }
}
