namespace Demo
{
   partial class Form1
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
         this.components = new System.ComponentModel.Container();
         this.lblCount = new System.Windows.Forms.Label();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.chkFontBold = new System.Windows.Forms.CheckBox();
         this.btnStop = new System.Windows.Forms.Button();
         this.btnRunningText = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.txtSpeed = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.txtText = new System.Windows.Forms.TextBox();
         this.btnForeColor = new System.Windows.Forms.Button();
         this.lblForeColor = new System.Windows.Forms.Label();
         this.btnBackColor = new System.Windows.Forms.Button();
         this.lblBackColor = new System.Windows.Forms.Label();
         this.btnClose = new System.Windows.Forms.Button();
         this.lblHeaderText = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.lblText = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblCount
         // 
         this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCount.Location = new System.Drawing.Point(541, 166);
         this.lblCount.Name = "lblCount";
         this.lblCount.Size = new System.Drawing.Size(76, 26);
         this.lblCount.TabIndex = 29;
         this.lblCount.Text = "0";
         this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.lblCount.TextChanged += new System.EventHandler(this.lblCount_TextChanged);
         // 
         // colorDialog1
         // 
         this.colorDialog1.FullOpen = true;
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // chkFontBold
         // 
         this.chkFontBold.AutoSize = true;
         this.chkFontBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkFontBold.Location = new System.Drawing.Point(661, 259);
         this.chkFontBold.Name = "chkFontBold";
         this.chkFontBold.Size = new System.Drawing.Size(97, 24);
         this.chkFontBold.TabIndex = 28;
         this.chkFontBold.Text = "Font Bold";
         this.chkFontBold.UseVisualStyleBackColor = true;
         this.chkFontBold.CheckedChanged += new System.EventHandler(this.chkFontBold_CheckedChanged);
         // 
         // btnStop
         // 
         this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnStop.Location = new System.Drawing.Point(144, 313);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(122, 31);
         this.btnStop.TabIndex = 3;
         this.btnStop.Text = "Stop";
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // btnRunningText
         // 
         this.btnRunningText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnRunningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRunningText.Location = new System.Drawing.Point(16, 313);
         this.btnRunningText.Name = "btnRunningText";
         this.btnRunningText.Size = new System.Drawing.Size(122, 31);
         this.btnRunningText.TabIndex = 2;
         this.btnRunningText.Text = "Running Text";
         this.btnRunningText.UseVisualStyleBackColor = true;
         this.btnRunningText.Click += new System.EventHandler(this.btnRunningText_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(100, 261);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(30, 20);
         this.label7.TabIndex = 25;
         this.label7.Text = "ms";
         // 
         // txtSpeed
         // 
         this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtSpeed.Location = new System.Drawing.Point(16, 258);
         this.txtSpeed.Name = "txtSpeed";
         this.txtSpeed.Size = new System.Drawing.Size(78, 26);
         this.txtSpeed.TabIndex = 1;
         this.txtSpeed.Text = "100";
         this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpeed_KeyPress);
         this.txtSpeed.Leave += new System.EventHandler(this.txtSpeed_Leave);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(12, 235);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(56, 20);
         this.label6.TabIndex = 23;
         this.label6.Text = "Speed";
         // 
         // txtText
         // 
         this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.txtText.Location = new System.Drawing.Point(16, 192);
         this.txtText.MaxLength = 45;
         this.txtText.Name = "txtText";
         this.txtText.Size = new System.Drawing.Size(601, 26);
         this.txtText.TabIndex = 0;
         this.txtText.Text = "Input Your Text Here";
         this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
         this.txtText.Enter += new System.EventHandler(this.txtText_Enter);
         this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
         this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
         // 
         // btnForeColor
         // 
         this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnForeColor.Location = new System.Drawing.Point(749, 195);
         this.btnForeColor.Name = "btnForeColor";
         this.btnForeColor.Size = new System.Drawing.Size(39, 23);
         this.btnForeColor.TabIndex = 20;
         this.btnForeColor.Text = "...";
         this.btnForeColor.UseVisualStyleBackColor = true;
         this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
         // 
         // lblForeColor
         // 
         this.lblForeColor.AutoSize = true;
         this.lblForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblForeColor.Location = new System.Drawing.Point(657, 196);
         this.lblForeColor.Name = "lblForeColor";
         this.lblForeColor.Size = new System.Drawing.Size(83, 20);
         this.lblForeColor.TabIndex = 19;
         this.lblForeColor.Text = "Fore Color";
         // 
         // btnBackColor
         // 
         this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnBackColor.Location = new System.Drawing.Point(749, 166);
         this.btnBackColor.Name = "btnBackColor";
         this.btnBackColor.Size = new System.Drawing.Size(39, 23);
         this.btnBackColor.TabIndex = 18;
         this.btnBackColor.Text = "...";
         this.btnBackColor.UseVisualStyleBackColor = true;
         this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
         // 
         // lblBackColor
         // 
         this.lblBackColor.AutoSize = true;
         this.lblBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBackColor.Location = new System.Drawing.Point(657, 167);
         this.lblBackColor.Name = "lblBackColor";
         this.lblBackColor.Size = new System.Drawing.Size(86, 20);
         this.lblBackColor.TabIndex = 17;
         this.lblBackColor.Text = "Back Color";
         // 
         // btnClose
         // 
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.Location = new System.Drawing.Point(756, 12);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(32, 32);
         this.btnClose.TabIndex = 2;
         this.btnClose.Text = "X";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // lblHeaderText
         // 
         this.lblHeaderText.AutoSize = true;
         this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblHeaderText.Location = new System.Drawing.Point(12, 9);
         this.lblHeaderText.Name = "lblHeaderText";
         this.lblHeaderText.Size = new System.Drawing.Size(297, 37);
         this.lblHeaderText.TabIndex = 0;
         this.lblHeaderText.Text = "My First Application";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(12, 166);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(39, 20);
         this.label5.TabIndex = 21;
         this.label5.Text = "Text";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
         this.panel1.Controls.Add(this.btnClose);
         this.panel1.Controls.Add(this.lblHeaderText);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(800, 60);
         this.panel1.TabIndex = 16;
         // 
         // lblText
         // 
         this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.lblText.Location = new System.Drawing.Point(12, 79);
         this.lblText.Name = "lblText";
         this.lblText.Size = new System.Drawing.Size(776, 73);
         this.lblText.TabIndex = 15;
         this.lblText.Text = "Input Your Text Here";
         this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 359);
         this.Controls.Add(this.lblCount);
         this.Controls.Add(this.chkFontBold);
         this.Controls.Add(this.btnStop);
         this.Controls.Add(this.btnRunningText);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.txtSpeed);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.txtText);
         this.Controls.Add(this.btnForeColor);
         this.Controls.Add(this.lblForeColor);
         this.Controls.Add(this.btnBackColor);
         this.Controls.Add(this.lblBackColor);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lblText);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.KeyPreview = true;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblCount;
      private System.Windows.Forms.ColorDialog colorDialog1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.CheckBox chkFontBold;
      private System.Windows.Forms.Button btnStop;
      private System.Windows.Forms.Button btnRunningText;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtSpeed;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox txtText;
      private System.Windows.Forms.Button btnForeColor;
      private System.Windows.Forms.Label lblForeColor;
      private System.Windows.Forms.Button btnBackColor;
      private System.Windows.Forms.Label lblBackColor;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Label lblHeaderText;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label lblText;
   }
}

