using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
   public partial class FrmColorMixing : Form
   {
      public FrmColorMixing()
      {
         InitializeComponent();
      }

      private void FrmColorMixing_Load(object sender, EventArgs e)
      {
         this.lblPreview.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
      }

      private void hsbRed_ValueChanged(object sender, EventArgs e)
      {
         var control = sender as HScrollBar;
         switch (control.Name)
         {
            case "hsbRed":
               this.lblRed.Text = this.hsbRed.Value.ToString();
               break;
            case "hsbGreen":
               this.lblGreen.Text = this.hsbGreen.Value.ToString();
               break;
            case "hsbBlue":
               this.lblBlue.Text = this.hsbBlue.Value.ToString();
               break;
         }
         this.lblPreview.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
      }

      private void txtColorName_Enter(object sender, EventArgs e)
      {
         if (this.txtColorName.Text.Trim().Equals("Color Name"))
         {
            this.txtColorName.Clear();
            this.txtColorName.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
         }
      }

      private void txtColorName_Leave(object sender, EventArgs e)
      {
         if (this.txtColorName.Text.Trim().Equals(""))
         {
            this.txtColorName.Text = "Color Name";
            this.txtColorName.ForeColor = Color.FromKnownColor(KnownColor.Silver);
         }
      }

      private bool NamaWarnaSudahTerpakai(string nama)
      {
         foreach (ComboBoxItem item in this.cboColor.Items)
         {
            if (item.ColorName.Equals(nama, StringComparison.CurrentCultureIgnoreCase))
            {
               return true;
            }
         }
         return false;
      }

      private void btnSimpan_Click(object sender, EventArgs e)
      {
         if (this.txtColorName.Text.Trim().Equals("Color Name") || this.txtColorName.Text.Trim().Equals(""))
         {
            MessageBox.Show("Sorry, Tentukan Nama untuk Komposisi Color Mixing Terlebih Dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
         else if (NamaWarnaSudahTerpakai(this.txtColorName.Text.Trim()))
         {
            MessageBox.Show("Sorry, Nama Warna Sudah Terpakai ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtColorName.Focus();
         }
         else
         {
            var newItem = new ComboBoxItem
            {
               ColorName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.txtColorName.Text.Trim()),
               Red = this.hsbRed.Value,
               Green = this.hsbGreen.Value,
               Blue = this.hsbBlue.Value
            };
            this.cboColor.Items.Add(newItem);
            this.txtColorName.Text = "Color Name";
            this.txtColorName.ForeColor = Color.FromKnownColor(KnownColor.Silver);

         }
      }

      private void txtColorName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (this.cboColor.Text.Trim() != string.Empty)
         {
            var itemWarna = this.cboColor.SelectedItem as ComboBoxItem;
            this.hsbRed.Value = itemWarna.Red;
            this.hsbGreen.Value = itemWarna.Green;
            this.hsbBlue.Value = itemWarna.Blue;
         }
      }
   }
}
