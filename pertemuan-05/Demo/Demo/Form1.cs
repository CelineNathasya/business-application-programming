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
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         int textLength = this.txtText.Text.Trim().Equals("Input Your Text Here") ? 0 : this.txtText.Text.Length;
         this.lblCount.Text = $"{textLength}/{this.txtText.MaxLength}";
         this.btnForeColor.BackColor = this.lblText.ForeColor;
         this.btnBackColor.BackColor = this.lblText.BackColor;
         this.btnStop.Enabled = false;
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void txtText_TextChanged(object sender, EventArgs e)
      {
         this.lblText.Text = this.txtText.Text;
         this.lblCount.Text = $"{this.txtText.Text.Length}/{this.txtText.MaxLength}";
      }

      private void txtText_Enter(object sender, EventArgs e)
      {
         if (this.txtText.Text.Equals("Input Your Text Here"))
         {
            this.txtText.Text = string.Empty;
            this.txtText.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            this.lblText.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
         }
      }

      private void txtText_Leave(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(this.txtText.Text.Trim()))
         {
            this.txtText.Text = "Input Your Text Here";
            this.txtText.ForeColor = Color.FromArgb(224, 224, 224);
            this.lblText.ForeColor = Color.FromArgb(224, 224, 224);
            int textLength = this.txtText.Text.Trim().Equals("Input Your Text Here") ? 0 : this.txtText.Text.Length;
            this.lblCount.Text = $"{textLength}/{this.txtText.MaxLength}";
         }
      }

      private void lblCount_TextChanged(object sender, EventArgs e)
      {
         string[] arr = this.lblCount.Text.Split('/');
         if (arr[0].Trim().Equals(arr[1].Trim()))
         {
            this.lblCount.ForeColor = Color.Red;
         }
         else
         {
            this.lblCount.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
         }
      }

      private void txtSpeed_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = true;
         if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
      }

      private void txtSpeed_Leave(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(this.txtSpeed.Text.Trim()))
         {
            this.txtSpeed.Text = "100";
         }
         else
         {
            this.txtSpeed.Text = Convert.ToInt32(this.txtSpeed.Text).ToString("n0");
         }
      }

      private void txtText_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
      }

      private void btnBackColor_Click(object sender, EventArgs e)
      {
         if (this.colorDialog1.ShowDialog() == DialogResult.OK)
         {
            this.lblText.BackColor = this.colorDialog1.Color;
            this.btnBackColor.BackColor = this.colorDialog1.Color;
         }
      }

      private void btnForeColor_Click(object sender, EventArgs e)
      {
         if (this.colorDialog1.ShowDialog() == DialogResult.OK)
         {
            this.lblText.ForeColor = this.colorDialog1.Color;
            this.btnForeColor.BackColor = this.colorDialog1.Color;
         }
      }

      private void chkFontBold_CheckedChanged(object sender, EventArgs e)
      {
         this.lblText.Font = new Font(this.lblText.Font.FontFamily.Name, this.lblText.Font.Size, this.chkFontBold.Checked ? FontStyle.Bold : FontStyle.Regular);
         this.chkFontBold.Font = new Font(this.chkFontBold.Font.FontFamily.Name, this.chkFontBold.Font.Size, this.chkFontBold.Checked ? FontStyle.Bold : FontStyle.Regular);
      }

      string text = "";

      private void btnRunningText_Click(object sender, EventArgs e)
      {
         if (this.txtText.Text.Trim().Equals("Input Your Text Here"))
         {
            MessageBox.Show("Set Text Anda Terlebih Dahulu ...", this.lblHeaderText.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
         else
         {
            text = this.lblText.Text;
            this.lblText.Text = string.Empty;
            idx = 0;
            this.txtText.Enabled = false;
            this.txtSpeed.Enabled = false;
            this.btnRunningText.Enabled = false;
            this.btnStop.Enabled = true;
            this.timer1.Interval = Convert.ToInt32(this.txtSpeed.Text);
            this.timer1.Start();
         }
      }

      int idx = 0;

      private void timer1_Tick(object sender, EventArgs e)
      {
         if (this.lblText.Text.Length != text.Length)
         {
            this.lblText.Text += text[idx++];
         }
         else
         {
            this.lblText.Text = string.Empty;
            idx = 0;
         }
      }

      private void btnStop_Click(object sender, EventArgs e)
      {
         this.timer1.Stop();
         this.lblText.Text = text;
         this.txtText.Enabled = true;
         this.txtSpeed.Enabled = true;
         this.btnRunningText.Enabled = true;
         this.btnStop.Enabled = false;
      }

      int mouse_left;
      int mouse_top;

      bool mouse_click = false;

      private void panel1_MouseDown(object sender, MouseEventArgs e)
      {
         this.mouse_left = e.X;
         this.mouse_top = e.Y;
         this.mouse_click = true;
      }

      private void panel1_MouseMove(object sender, MouseEventArgs e)
      {
         if (mouse_click)
         {
            if (e.X > this.mouse_left)
            {
               this.Left += (e.X - this.mouse_left);
            }
            else
            {
               this.Left -= (this.mouse_left - e.X);
            }
            if (e.Y > this.mouse_top)
            {
               this.Top += (e.Y - this.mouse_top);
            }
            else
            {
               this.Top -= (this.mouse_top - e.Y);
            }
         }
      }

      private void panel1_MouseUp(object sender, MouseEventArgs e)
      {
         this.mouse_click = false;
      }

   }
}
