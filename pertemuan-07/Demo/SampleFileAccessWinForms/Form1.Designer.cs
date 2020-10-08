namespace SampleFileAccessWinForms
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         this.grpItemData = new System.Windows.Forms.GroupBox();
         this.btnBatal = new System.Windows.Forms.Button();
         this.btnSimpan = new System.Windows.Forms.Button();
         this.cboKelas = new System.Windows.Forms.ComboBox();
         this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.txtTanggalLahir = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtTempatLahir = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtNim = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.grpTabelData = new System.Windows.Forms.GroupBox();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.grpItemData.SuspendLayout();
         this.grpTabelData.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpItemData
         // 
         this.grpItemData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpItemData.Controls.Add(this.btnBatal);
         this.grpItemData.Controls.Add(this.btnSimpan);
         this.grpItemData.Controls.Add(this.cboKelas);
         this.grpItemData.Controls.Add(this.cboWaktuKuliah);
         this.grpItemData.Controls.Add(this.label6);
         this.grpItemData.Controls.Add(this.label5);
         this.grpItemData.Controls.Add(this.txtTanggalLahir);
         this.grpItemData.Controls.Add(this.label4);
         this.grpItemData.Controls.Add(this.txtTempatLahir);
         this.grpItemData.Controls.Add(this.label3);
         this.grpItemData.Controls.Add(this.txtNama);
         this.grpItemData.Controls.Add(this.label2);
         this.grpItemData.Controls.Add(this.txtNim);
         this.grpItemData.Controls.Add(this.label1);
         this.grpItemData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.grpItemData.Location = new System.Drawing.Point(12, 12);
         this.grpItemData.Name = "grpItemData";
         this.grpItemData.Size = new System.Drawing.Size(776, 259);
         this.grpItemData.TabIndex = 0;
         this.grpItemData.TabStop = false;
         this.grpItemData.Text = "Item Data";
         // 
         // btnBatal
         // 
         this.btnBatal.Location = new System.Drawing.Point(99, 218);
         this.btnBatal.Name = "btnBatal";
         this.btnBatal.Size = new System.Drawing.Size(75, 25);
         this.btnBatal.TabIndex = 7;
         this.btnBatal.Text = "Batal";
         this.btnBatal.UseVisualStyleBackColor = true;
         this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
         // 
         // btnSimpan
         // 
         this.btnSimpan.Location = new System.Drawing.Point(18, 218);
         this.btnSimpan.Name = "btnSimpan";
         this.btnSimpan.Size = new System.Drawing.Size(75, 25);
         this.btnSimpan.TabIndex = 6;
         this.btnSimpan.Text = "Simpan";
         this.btnSimpan.UseVisualStyleBackColor = true;
         this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
         // 
         // cboKelas
         // 
         this.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboKelas.FormattingEnabled = true;
         this.cboKelas.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
         this.cboKelas.Location = new System.Drawing.Point(122, 173);
         this.cboKelas.Name = "cboKelas";
         this.cboKelas.Size = new System.Drawing.Size(90, 24);
         this.cboKelas.TabIndex = 5;
         this.cboKelas.Enter += new System.EventHandler(this.txtNim_Enter);
         this.cboKelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.cboKelas.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // cboWaktuKuliah
         // 
         this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboWaktuKuliah.FormattingEnabled = true;
         this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
         this.cboWaktuKuliah.Location = new System.Drawing.Point(122, 144);
         this.cboWaktuKuliah.Name = "cboWaktuKuliah";
         this.cboWaktuKuliah.Size = new System.Drawing.Size(90, 24);
         this.cboWaktuKuliah.TabIndex = 4;
         this.cboWaktuKuliah.Enter += new System.EventHandler(this.txtNim_Enter);
         this.cboWaktuKuliah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.cboWaktuKuliah.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // label6
         // 
         this.label6.Location = new System.Drawing.Point(15, 174);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(101, 23);
         this.label6.TabIndex = 20;
         this.label6.Text = "Kelas";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(15, 145);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(101, 23);
         this.label5.TabIndex = 18;
         this.label5.Text = "Waktu Kuliah";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtTanggalLahir
         // 
         this.txtTanggalLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTanggalLahir.Location = new System.Drawing.Point(122, 116);
         this.txtTanggalLahir.MaxLength = 10;
         this.txtTanggalLahir.Name = "txtTanggalLahir";
         this.txtTanggalLahir.Size = new System.Drawing.Size(90, 23);
         this.txtTanggalLahir.TabIndex = 3;
         this.txtTanggalLahir.Enter += new System.EventHandler(this.txtNim_Enter);
         this.txtTanggalLahir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.txtTanggalLahir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTanggalLahir_KeyPress);
         this.txtTanggalLahir.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(15, 116);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(101, 23);
         this.label4.TabIndex = 16;
         this.label4.Text = "Tanggal Lahir";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtTempatLahir
         // 
         this.txtTempatLahir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTempatLahir.Location = new System.Drawing.Point(122, 87);
         this.txtTempatLahir.Name = "txtTempatLahir";
         this.txtTempatLahir.Size = new System.Drawing.Size(432, 23);
         this.txtTempatLahir.TabIndex = 2;
         this.txtTempatLahir.Enter += new System.EventHandler(this.txtNim_Enter);
         this.txtTempatLahir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.txtTempatLahir.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(15, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(101, 23);
         this.label3.TabIndex = 14;
         this.label3.Text = "Tempat Lahir";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtNama
         // 
         this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNama.Location = new System.Drawing.Point(122, 58);
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(432, 23);
         this.txtNama.TabIndex = 1;
         this.txtNama.Enter += new System.EventHandler(this.txtNim_Enter);
         this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.txtNama.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(15, 58);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(101, 23);
         this.label2.TabIndex = 12;
         this.label2.Text = "Nama";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtNim
         // 
         this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNim.Location = new System.Drawing.Point(122, 29);
         this.txtNim.MaxLength = 9;
         this.txtNim.Name = "txtNim";
         this.txtNim.Size = new System.Drawing.Size(90, 23);
         this.txtNim.TabIndex = 0;
         this.txtNim.Enter += new System.EventHandler(this.txtNim_Enter);
         this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
         this.txtNim.Leave += new System.EventHandler(this.txtNim_Leave);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(15, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(101, 23);
         this.label1.TabIndex = 10;
         this.label1.Text = "Nim";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // grpTabelData
         // 
         this.grpTabelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpTabelData.Controls.Add(this.dgvData);
         this.grpTabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.grpTabelData.Location = new System.Drawing.Point(12, 277);
         this.grpTabelData.Name = "grpTabelData";
         this.grpTabelData.Size = new System.Drawing.Size(776, 272);
         this.grpTabelData.TabIndex = 1;
         this.grpTabelData.TabStop = false;
         this.grpTabelData.Text = "Tabel Data";
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
         this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
         this.dgvData.Location = new System.Drawing.Point(6, 22);
         this.dgvData.MultiSelect = false;
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.Size = new System.Drawing.Size(764, 244);
         this.dgvData.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Nim";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Nama";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Width = 200;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Tmpt. Lahir";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         this.Column3.Width = 125;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Tgl. Lahir";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Waktu Kuliah";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         this.Column5.Width = 120;
         // 
         // Column6
         // 
         this.Column6.HeaderText = "Kelas";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.hapusToolStripMenuItem});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.editToolStripMenuItem.Text = "Edit";
         this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
         // 
         // hapusToolStripMenuItem
         // 
         this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
         this.hapusToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.hapusToolStripMenuItem.Text = "Hapus";
         this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 561);
         this.Controls.Add(this.grpItemData);
         this.Controls.Add(this.grpTabelData);
         this.KeyPreview = true;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "File Access WinForms Sample App";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Form1_Load);
         this.Resize += new System.EventHandler(this.Form1_Resize);
         this.grpItemData.ResumeLayout(false);
         this.grpItemData.PerformLayout();
         this.grpTabelData.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpItemData;
      private System.Windows.Forms.GroupBox grpTabelData;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtTanggalLahir;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtTempatLahir;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtNim;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cboWaktuKuliah;
      private System.Windows.Forms.ComboBox cboKelas;
      private System.Windows.Forms.Button btnBatal;
      private System.Windows.Forms.Button btnSimpan;
      private System.Windows.Forms.DataGridView dgvData;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
   }
}

