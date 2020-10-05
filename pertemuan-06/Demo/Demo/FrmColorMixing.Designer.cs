namespace Demo
{
   partial class FrmColorMixing
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtColorName = new System.Windows.Forms.TextBox();
         this.btnSimpan = new System.Windows.Forms.Button();
         this.cboColor = new System.Windows.Forms.ComboBox();
         this.label9 = new System.Windows.Forms.Label();
         this.lblBlue = new System.Windows.Forms.Label();
         this.hsbBlue = new System.Windows.Forms.HScrollBar();
         this.label8 = new System.Windows.Forms.Label();
         this.lblGreen = new System.Windows.Forms.Label();
         this.hsbGreen = new System.Windows.Forms.HScrollBar();
         this.label5 = new System.Windows.Forms.Label();
         this.lblRed = new System.Windows.Forms.Label();
         this.hsbRed = new System.Windows.Forms.HScrollBar();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblPreview = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtColorName);
         this.groupBox1.Controls.Add(this.btnSimpan);
         this.groupBox1.Controls.Add(this.cboColor);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Location = new System.Drawing.Point(15, 275);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(522, 140);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "My Color";
         // 
         // txtColorName
         // 
         this.txtColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtColorName.ForeColor = System.Drawing.Color.Silver;
         this.txtColorName.Location = new System.Drawing.Point(19, 29);
         this.txtColorName.Name = "txtColorName";
         this.txtColorName.Size = new System.Drawing.Size(224, 26);
         this.txtColorName.TabIndex = 0;
         this.txtColorName.Text = "Color Name";
         this.txtColorName.Enter += new System.EventHandler(this.txtColorName_Enter);
         this.txtColorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorName_KeyDown);
         this.txtColorName.Leave += new System.EventHandler(this.txtColorName_Leave);
         // 
         // btnSimpan
         // 
         this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSimpan.Location = new System.Drawing.Point(249, 29);
         this.btnSimpan.Name = "btnSimpan";
         this.btnSimpan.Size = new System.Drawing.Size(75, 26);
         this.btnSimpan.TabIndex = 1;
         this.btnSimpan.Text = "&Simpan";
         this.btnSimpan.UseVisualStyleBackColor = true;
         this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
         // 
         // cboColor
         // 
         this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboColor.FormattingEnabled = true;
         this.cboColor.Location = new System.Drawing.Point(19, 95);
         this.cboColor.Name = "cboColor";
         this.cboColor.Size = new System.Drawing.Size(224, 28);
         this.cboColor.TabIndex = 2;
         this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
         // 
         // label9
         // 
         this.label9.Location = new System.Drawing.Point(16, 69);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(100, 23);
         this.label9.TabIndex = 2;
         this.label9.Text = "Saved Color";
         this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblBlue
         // 
         this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBlue.ForeColor = System.Drawing.Color.Blue;
         this.lblBlue.Location = new System.Drawing.Point(486, 202);
         this.lblBlue.Name = "lblBlue";
         this.lblBlue.Size = new System.Drawing.Size(51, 23);
         this.lblBlue.TabIndex = 24;
         this.lblBlue.Text = "0";
         this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // hsbBlue
         // 
         this.hsbBlue.LargeChange = 1;
         this.hsbBlue.Location = new System.Drawing.Point(12, 225);
         this.hsbBlue.Maximum = 255;
         this.hsbBlue.Name = "hsbBlue";
         this.hsbBlue.Size = new System.Drawing.Size(525, 24);
         this.hsbBlue.TabIndex = 2;
         this.hsbBlue.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
         // 
         // label8
         // 
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.Blue;
         this.label8.Location = new System.Drawing.Point(12, 202);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(51, 23);
         this.label8.TabIndex = 23;
         this.label8.Text = "Blue";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblGreen
         // 
         this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblGreen.ForeColor = System.Drawing.Color.Green;
         this.lblGreen.Location = new System.Drawing.Point(486, 155);
         this.lblGreen.Name = "lblGreen";
         this.lblGreen.Size = new System.Drawing.Size(51, 23);
         this.lblGreen.TabIndex = 22;
         this.lblGreen.Text = "0";
         this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // hsbGreen
         // 
         this.hsbGreen.LargeChange = 1;
         this.hsbGreen.Location = new System.Drawing.Point(12, 178);
         this.hsbGreen.Maximum = 255;
         this.hsbGreen.Name = "hsbGreen";
         this.hsbGreen.Size = new System.Drawing.Size(525, 24);
         this.hsbGreen.TabIndex = 1;
         this.hsbGreen.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
         // 
         // label5
         // 
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.Green;
         this.label5.Location = new System.Drawing.Point(12, 155);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(51, 23);
         this.label5.TabIndex = 21;
         this.label5.Text = "Green";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblRed
         // 
         this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRed.ForeColor = System.Drawing.Color.Red;
         this.lblRed.Location = new System.Drawing.Point(486, 108);
         this.lblRed.Name = "lblRed";
         this.lblRed.Size = new System.Drawing.Size(51, 23);
         this.lblRed.TabIndex = 20;
         this.lblRed.Text = "0";
         this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // hsbRed
         // 
         this.hsbRed.LargeChange = 1;
         this.hsbRed.Location = new System.Drawing.Point(12, 131);
         this.hsbRed.Maximum = 255;
         this.hsbRed.Name = "hsbRed";
         this.hsbRed.Size = new System.Drawing.Size(525, 24);
         this.hsbRed.TabIndex = 0;
         this.hsbRed.ValueChanged += new System.EventHandler(this.hsbRed_ValueChanged);
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Red;
         this.label3.Location = new System.Drawing.Point(12, 108);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(51, 23);
         this.label3.TabIndex = 19;
         this.label3.Text = "Red";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(9, 6);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 23);
         this.label2.TabIndex = 17;
         this.label2.Text = "Preview";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblPreview
         // 
         this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.lblPreview.Location = new System.Drawing.Point(12, 30);
         this.lblPreview.Name = "lblPreview";
         this.lblPreview.Size = new System.Drawing.Size(525, 67);
         this.lblPreview.TabIndex = 15;
         // 
         // FrmColorMixing
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(549, 427);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.lblBlue);
         this.Controls.Add(this.hsbBlue);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.lblGreen);
         this.Controls.Add(this.hsbGreen);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.lblRed);
         this.Controls.Add(this.hsbRed);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lblPreview);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmColorMixing";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Color Mixing";
         this.Load += new System.EventHandler(this.FrmColorMixing_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtColorName;
      private System.Windows.Forms.Button btnSimpan;
      private System.Windows.Forms.ComboBox cboColor;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label lblBlue;
      private System.Windows.Forms.HScrollBar hsbBlue;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label lblGreen;
      private System.Windows.Forms.HScrollBar hsbGreen;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblRed;
      private System.Windows.Forms.HScrollBar hsbRed;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblPreview;
   }
}

