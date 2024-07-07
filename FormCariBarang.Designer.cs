namespace WinFormsBarang
{
    partial class FormCariBarang
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
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.lbBarangDicari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBarang.Location = new System.Drawing.Point(12, 39);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowTemplate.Height = 25;
            this.dgvBarang.Size = new System.Drawing.Size(484, 143);
            this.dgvBarang.TabIndex = 5;
            this.dgvBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBarang_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeBarang";
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaBarang";
            this.Column2.HeaderText = "NamaBarang";
            this.Column2.Name = "Column2";
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "stok";
            this.Column3.HeaderText = "Stok";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "satuan";
            this.Column4.HeaderText = "Satuan";
            this.Column4.Name = "Column4";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(164, 10);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(329, 23);
            this.tbNamaBarang.TabIndex = 4;
            this.tbNamaBarang.TextChanged += new System.EventHandler(this.tbNamaBarang_TextChanged);
            this.tbNamaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaBarang_KeyDown);
            // 
            // lbBarangDicari
            // 
            this.lbBarangDicari.AutoSize = true;
            this.lbBarangDicari.Location = new System.Drawing.Point(12, 13);
            this.lbBarangDicari.Name = "lbBarangDicari";
            this.lbBarangDicari.Size = new System.Drawing.Size(140, 15);
            this.lbBarangDicari.TabIndex = 3;
            this.lbBarangDicari.Text = "Nama Barang yang dicari";
            // 
            // FormCariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 199);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.lbBarangDicari);
            this.Name = "FormCariBarang";
            this.Text = "FormCariBarang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCariBarang_FormClosed);
            this.Load += new System.EventHandler(this.FormCariBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBarang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbNamaBarang;
        private Label lbBarangDicari;
    }
}