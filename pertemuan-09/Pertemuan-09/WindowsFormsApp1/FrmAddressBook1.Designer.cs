namespace WindowsFormsApp1
{
   partial class FrmAddressBook1
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.grpData = new System.Windows.Forms.GroupBox();
         this.btnBatal = new System.Windows.Forms.Button();
         this.btnSimpan = new System.Windows.Forms.Button();
         this.grpPict = new System.Windows.Forms.GroupBox();
         this.pictBox = new System.Windows.Forms.PictureBox();
         this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.txtKeterangan = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.txtNomorHP = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtKodePos = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtKota = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtAlamat = new System.Windows.Forms.TextBox();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.lblHariTanggalDanWaktu = new System.Windows.Forms.ToolStripStatusLabel();
         this.grpListData = new System.Windows.Forms.GroupBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.btnFilter = new System.Windows.Forms.Button();
         this.txtNamaQuery = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.hapusDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.grpData.SuspendLayout();
         this.grpPict.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
         this.contextMenuStrip2.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.grpListData.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpData
         // 
         this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpData.Controls.Add(this.btnBatal);
         this.grpData.Controls.Add(this.btnSimpan);
         this.grpData.Controls.Add(this.grpPict);
         this.grpData.Controls.Add(this.txtKeterangan);
         this.grpData.Controls.Add(this.label6);
         this.grpData.Controls.Add(this.txtNomorHP);
         this.grpData.Controls.Add(this.label5);
         this.grpData.Controls.Add(this.txtKodePos);
         this.grpData.Controls.Add(this.label4);
         this.grpData.Controls.Add(this.txtKota);
         this.grpData.Controls.Add(this.label3);
         this.grpData.Controls.Add(this.txtAlamat);
         this.grpData.Controls.Add(this.txtNama);
         this.grpData.Controls.Add(this.label2);
         this.grpData.Controls.Add(this.label1);
         this.grpData.Location = new System.Drawing.Point(12, 12);
         this.grpData.Name = "grpData";
         this.grpData.Size = new System.Drawing.Size(973, 221);
         this.grpData.TabIndex = 0;
         this.grpData.TabStop = false;
         this.grpData.Text = "Data";
         this.grpData.Enter += new System.EventHandler(this.groupBox1_Enter);
         // 
         // btnBatal
         // 
         this.btnBatal.Location = new System.Drawing.Point(179, 192);
         this.btnBatal.Name = "btnBatal";
         this.btnBatal.Size = new System.Drawing.Size(75, 23);
         this.btnBatal.TabIndex = 7;
         this.btnBatal.Text = "&Batal";
         this.btnBatal.UseVisualStyleBackColor = true;
         // 
         // btnSimpan
         // 
         this.btnSimpan.Location = new System.Drawing.Point(98, 192);
         this.btnSimpan.Name = "btnSimpan";
         this.btnSimpan.Size = new System.Drawing.Size(75, 23);
         this.btnSimpan.TabIndex = 6;
         this.btnSimpan.Text = "&Simpan";
         this.btnSimpan.UseVisualStyleBackColor = true;
         // 
         // grpPict
         // 
         this.grpPict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.grpPict.Controls.Add(this.pictBox);
         this.grpPict.Location = new System.Drawing.Point(829, 19);
         this.grpPict.Name = "grpPict";
         this.grpPict.Size = new System.Drawing.Size(128, 168);
         this.grpPict.TabIndex = 13;
         this.grpPict.TabStop = false;
         this.grpPict.Text = "Pict";
         // 
         // pictBox
         // 
         this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictBox.ContextMenuStrip = this.contextMenuStrip2;
         this.pictBox.Location = new System.Drawing.Point(6, 19);
         this.pictBox.Name = "pictBox";
         this.pictBox.Size = new System.Drawing.Size(116, 139);
         this.pictBox.TabIndex = 0;
         this.pictBox.TabStop = false;
         // 
         // contextMenuStrip2
         // 
         this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem});
         this.contextMenuStrip2.Name = "contextMenuStrip2";
         this.contextMenuStrip2.Size = new System.Drawing.Size(102, 48);
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
         this.loadToolStripMenuItem.Text = "Load";
         // 
         // clearToolStripMenuItem
         // 
         this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
         this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
         this.clearToolStripMenuItem.Text = "Clear";
         // 
         // txtKeterangan
         // 
         this.txtKeterangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtKeterangan.Location = new System.Drawing.Point(98, 157);
         this.txtKeterangan.MaxLength = 500;
         this.txtKeterangan.Name = "txtKeterangan";
         this.txtKeterangan.Size = new System.Drawing.Size(688, 20);
         this.txtKeterangan.TabIndex = 5;
         // 
         // label6
         // 
         this.label6.Location = new System.Drawing.Point(22, 157);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(100, 20);
         this.label6.TabIndex = 10;
         this.label6.Text = "Keterangan";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtNomorHP
         // 
         this.txtNomorHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNomorHP.Location = new System.Drawing.Point(98, 131);
         this.txtNomorHP.MaxLength = 50;
         this.txtNomorHP.Name = "txtNomorHP";
         this.txtNomorHP.Size = new System.Drawing.Size(350, 20);
         this.txtNomorHP.TabIndex = 4;
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(22, 131);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(100, 20);
         this.label5.TabIndex = 8;
         this.label5.Text = "Nomor HP";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtKodePos
         // 
         this.txtKodePos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtKodePos.Location = new System.Drawing.Point(98, 105);
         this.txtKodePos.MaxLength = 5;
         this.txtKodePos.Name = "txtKodePos";
         this.txtKodePos.Size = new System.Drawing.Size(100, 20);
         this.txtKodePos.TabIndex = 3;
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(22, 105);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(100, 20);
         this.label4.TabIndex = 6;
         this.label4.Text = "Kode Pos";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtKota
         // 
         this.txtKota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtKota.Location = new System.Drawing.Point(98, 79);
         this.txtKota.MaxLength = 100;
         this.txtKota.Name = "txtKota";
         this.txtKota.Size = new System.Drawing.Size(350, 20);
         this.txtKota.TabIndex = 2;
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(22, 79);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 20);
         this.label3.TabIndex = 4;
         this.label3.Text = "Kota";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtAlamat
         // 
         this.txtAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtAlamat.Location = new System.Drawing.Point(98, 53);
         this.txtAlamat.MaxLength = 300;
         this.txtAlamat.Name = "txtAlamat";
         this.txtAlamat.Size = new System.Drawing.Size(688, 20);
         this.txtAlamat.TabIndex = 1;
         // 
         // txtNama
         // 
         this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNama.Location = new System.Drawing.Point(98, 27);
         this.txtNama.MaxLength = 100;
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(350, 20);
         this.txtNama.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(22, 53);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "Alamat";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(22, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHariTanggalDanWaktu});
         this.statusStrip1.Location = new System.Drawing.Point(0, 594);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(997, 22);
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // lblHariTanggalDanWaktu
         // 
         this.lblHariTanggalDanWaktu.Name = "lblHariTanggalDanWaktu";
         this.lblHariTanggalDanWaktu.Size = new System.Drawing.Size(982, 17);
         this.lblHariTanggalDanWaktu.Spring = true;
         this.lblHariTanggalDanWaktu.Text = "{ hari, tanggal dan waktu }";
         this.lblHariTanggalDanWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // grpListData
         // 
         this.grpListData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpListData.Controls.Add(this.splitContainer1);
         this.grpListData.Location = new System.Drawing.Point(12, 239);
         this.grpListData.Name = "grpListData";
         this.grpListData.Size = new System.Drawing.Size(973, 352);
         this.grpListData.TabIndex = 1;
         this.grpListData.TabStop = false;
         this.grpListData.Text = "List Data";
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(3, 16);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
         this.splitContainer1.Panel1.Controls.Add(this.txtNamaQuery);
         this.splitContainer1.Panel1.Controls.Add(this.label7);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.dgvData);
         this.splitContainer1.Size = new System.Drawing.Size(967, 333);
         this.splitContainer1.SplitterDistance = 40;
         this.splitContainer1.TabIndex = 0;
         // 
         // btnFilter
         // 
         this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnFilter.Location = new System.Drawing.Point(879, 9);
         this.btnFilter.Name = "btnFilter";
         this.btnFilter.Size = new System.Drawing.Size(75, 23);
         this.btnFilter.TabIndex = 1;
         this.btnFilter.Text = "&Filter";
         this.btnFilter.UseVisualStyleBackColor = true;
         // 
         // txtNamaQuery
         // 
         this.txtNamaQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtNamaQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNamaQuery.Location = new System.Drawing.Point(95, 10);
         this.txtNamaQuery.Name = "txtNamaQuery";
         this.txtNamaQuery.Size = new System.Drawing.Size(778, 20);
         this.txtNamaQuery.TabIndex = 0;
         // 
         // label7
         // 
         this.label7.Location = new System.Drawing.Point(19, 10);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(100, 20);
         this.label7.TabIndex = 2;
         this.label7.Text = "Nama";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
         this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
         this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvData.EnableHeadersVisualStyles = false;
         this.dgvData.Location = new System.Drawing.Point(0, 0);
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.Size = new System.Drawing.Size(967, 289);
         this.dgvData.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "No";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Visible = false;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Nama";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Alamat";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Kota";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Kode Pos";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         // 
         // Column6
         // 
         this.Column6.HeaderText = "Nomor HP";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         // 
         // Column7
         // 
         this.Column7.HeaderText = "Keterangan";
         this.Column7.Name = "Column7";
         this.Column7.ReadOnly = true;
         // 
         // Column8
         // 
         this.Column8.HeaderText = "Created Date";
         this.Column8.Name = "Column8";
         this.Column8.ReadOnly = true;
         // 
         // Column9
         // 
         this.Column9.HeaderText = "Updated Date";
         this.Column9.Name = "Column9";
         this.Column9.ReadOnly = true;
         // 
         // Column10
         // 
         this.Column10.HeaderText = "picture";
         this.Column10.Name = "Column10";
         this.Column10.ReadOnly = true;
         this.Column10.Visible = false;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataToolStripMenuItem,
            this.hapusDataToolStripMenuItem});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
         // 
         // editDataToolStripMenuItem
         // 
         this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
         this.editDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
         this.editDataToolStripMenuItem.Text = "Edit Data";
         // 
         // hapusDataToolStripMenuItem
         // 
         this.hapusDataToolStripMenuItem.Name = "hapusDataToolStripMenuItem";
         this.hapusDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
         this.hapusDataToolStripMenuItem.Text = "Hapus Data";
         // 
         // FrmAddressBook1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(997, 616);
         this.Controls.Add(this.grpListData);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.grpData);
         this.KeyPreview = true;
         this.Name = "FrmAddressBook1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Data Address Book - 1";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.grpData.ResumeLayout(false);
         this.grpData.PerformLayout();
         this.grpPict.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
         this.contextMenuStrip2.ResumeLayout(false);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.grpListData.ResumeLayout(false);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox grpData;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.TextBox txtAlamat;
      private System.Windows.Forms.TextBox txtKota;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtKodePos;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtNomorHP;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtKeterangan;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.GroupBox grpPict;
      private System.Windows.Forms.PictureBox pictBox;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel lblHariTanggalDanWaktu;
      private System.Windows.Forms.Button btnSimpan;
      private System.Windows.Forms.Button btnBatal;
      private System.Windows.Forms.GroupBox grpListData;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Button btnFilter;
      private System.Windows.Forms.TextBox txtNamaQuery;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.DataGridView dgvData;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem hapusDataToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
   }
}