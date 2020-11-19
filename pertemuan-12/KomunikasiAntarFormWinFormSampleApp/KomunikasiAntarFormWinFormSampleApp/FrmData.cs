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
   public partial class FrmData : Form
   {
      public FrmData()
      {
         InitializeComponent();
         this.dgvData.AutoGenerateColumns = false;
         this.lblBanyakRecordData.Text = $"{this.dgvData.Rows.Count:n0} Record Data.";
      }

      private void btnTambahAndReturnObject_Click(object sender, EventArgs e)
      {
         var form = new FrmTambahData();
         var returnValue = form.RunAndReturnObjectMahasiswa(form);
         if (returnValue != null)
         {
            this.dgvData.Rows.Add(new string[] { returnValue.Nim, returnValue.Nama });
         }
      }

      private void btnTambahAndReturnTuple_Click(object sender, EventArgs e)
      {
         var form = new FrmTambahData();
         var (nim, nama) = form.RunAndReturnTupleMahasiswa(form);
         if (nim != "" && nama != "")
         {
            this.dgvData.Rows.Add(new string[] { nim, nama });
         }
      }

      private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
      {
         this.lblBanyakRecordData.Text = $"{this.dgvData.Rows.Count:n0} Record Data.";
      }

      private void hapusItemDataToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            if (MessageBox.Show("Hapus Baris Data Terpilih ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               var row = this.dgvData.CurrentRow;
               this.dgvData.Rows.Remove(row);
            }
         }
      }

      private void dgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
      {
         this.lblBanyakRecordData.Text = $"{this.dgvData.Rows.Count:n0} Record Data.";
      }

      private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (this.dgvData.CurrentRow != null)
         {
            var row = this.dgvData.CurrentRow;
            string nim = row.Cells[0].Value.ToString().Trim();
            string nama = row.Cells[1].Value.ToString().Trim();
            //FrmTambahData form = new FrmTambahData(nim, nama);
            FrmTambahData form = new FrmTambahData(new Mahasiswa { Nim = nim, Nama = nama });
            var returnValue = form.RunAndReturnObjectMahasiswa(form);
            if (returnValue != null)
            {
               row.Cells[0].Value = returnValue.Nim;
               row.Cells[1].Value = returnValue.Nama;
            }
         }
      }

   }
}
