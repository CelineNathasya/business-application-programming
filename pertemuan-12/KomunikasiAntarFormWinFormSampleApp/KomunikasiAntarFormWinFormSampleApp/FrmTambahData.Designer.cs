
namespace KomunikasiAntarFormWinFormSampleApp
{
   partial class FrmTambahData
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblBanyakRecordData = new System.Windows.Forms.Label();
         this.txtNim = new System.Windows.Forms.TextBox();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnOK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblBanyakRecordData
         // 
         this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 15);
         this.lblBanyakRecordData.Name = "lblBanyakRecordData";
         this.lblBanyakRecordData.Size = new System.Drawing.Size(52, 20);
         this.lblBanyakRecordData.TabIndex = 3;
         this.lblBanyakRecordData.Text = "Nim";
         this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtNim
         // 
         this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNim.Location = new System.Drawing.Point(70, 15);
         this.txtNim.Name = "txtNim";
         this.txtNim.Size = new System.Drawing.Size(180, 20);
         this.txtNim.TabIndex = 0;
         this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         // 
         // txtNama
         // 
         this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNama.Location = new System.Drawing.Point(70, 41);
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(180, 20);
         this.txtNama.TabIndex = 1;
         this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(12, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(52, 20);
         this.label1.TabIndex = 5;
         this.label1.Text = "Nama";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(175, 81);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 2;
         this.btnOK.Text = "&OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // FrmTambahData
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(265, 112);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.txtNama);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtNim);
         this.Controls.Add(this.lblBanyakRecordData);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmTambahData";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Tambah Data ";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTambahData_KeyDown);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.TextBox txtNim;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnOK;
   }
}