
namespace KomunikasiAntarFormWinFormSampleApp
{
   partial class FrmData
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
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.btnTambahAndReturnObject = new System.Windows.Forms.Button();
         this.lblBanyakRecordData = new System.Windows.Forms.Label();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnTambahAndReturnTuple = new System.Windows.Forms.Button();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.hapusItemDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
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
            this.Column2});
         this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
         this.dgvData.EnableHeadersVisualStyles = false;
         this.dgvData.Location = new System.Drawing.Point(12, 74);
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.Size = new System.Drawing.Size(560, 425);
         this.dgvData.TabIndex = 0;
         this.dgvData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvData_RowsAdded);
         this.dgvData.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvData_RowsRemoved);
         // 
         // btnTambahAndReturnObject
         // 
         this.btnTambahAndReturnObject.Location = new System.Drawing.Point(12, 12);
         this.btnTambahAndReturnObject.Name = "btnTambahAndReturnObject";
         this.btnTambahAndReturnObject.Size = new System.Drawing.Size(146, 23);
         this.btnTambahAndReturnObject.TabIndex = 1;
         this.btnTambahAndReturnObject.Text = "Tambah And Return Object";
         this.btnTambahAndReturnObject.UseVisualStyleBackColor = true;
         this.btnTambahAndReturnObject.Click += new System.EventHandler(this.btnTambahAndReturnObject_Click);
         // 
         // lblBanyakRecordData
         // 
         this.lblBanyakRecordData.Location = new System.Drawing.Point(9, 51);
         this.lblBanyakRecordData.Name = "lblBanyakRecordData";
         this.lblBanyakRecordData.Size = new System.Drawing.Size(258, 20);
         this.lblBanyakRecordData.TabIndex = 2;
         this.lblBanyakRecordData.Text = "{ banyak record data }";
         this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Nim";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Width = 200;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Nama";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Width = 250;
         // 
         // btnTambahAndReturnTuple
         // 
         this.btnTambahAndReturnTuple.Location = new System.Drawing.Point(164, 12);
         this.btnTambahAndReturnTuple.Name = "btnTambahAndReturnTuple";
         this.btnTambahAndReturnTuple.Size = new System.Drawing.Size(146, 23);
         this.btnTambahAndReturnTuple.TabIndex = 3;
         this.btnTambahAndReturnTuple.Text = "Tambah And Return Tuple";
         this.btnTambahAndReturnTuple.UseVisualStyleBackColor = true;
         this.btnTambahAndReturnTuple.Click += new System.EventHandler(this.btnTambahAndReturnTuple_Click);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hapusItemDataToolStripMenuItem});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(163, 26);
         // 
         // hapusItemDataToolStripMenuItem
         // 
         this.hapusItemDataToolStripMenuItem.Name = "hapusItemDataToolStripMenuItem";
         this.hapusItemDataToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
         this.hapusItemDataToolStripMenuItem.Text = "Hapus Item Data";
         this.hapusItemDataToolStripMenuItem.Click += new System.EventHandler(this.hapusItemDataToolStripMenuItem_Click);
         // 
         // FrmData
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(584, 511);
         this.Controls.Add(this.btnTambahAndReturnTuple);
         this.Controls.Add(this.lblBanyakRecordData);
         this.Controls.Add(this.btnTambahAndReturnObject);
         this.Controls.Add(this.dgvData);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmData";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form Data";
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvData;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.Button btnTambahAndReturnObject;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.Button btnTambahAndReturnTuple;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem hapusItemDataToolStripMenuItem;
   }
}

