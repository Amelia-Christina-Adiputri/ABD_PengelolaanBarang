namespace WinFormsBarang
{
    partial class FormCariSupplier
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
            this.lbSupplierDicari = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSupplierDicari
            // 
            this.lbSupplierDicari.AutoSize = true;
            this.lbSupplierDicari.Location = new System.Drawing.Point(12, 9);
            this.lbSupplierDicari.Name = "lbSupplierDicari";
            this.lbSupplierDicari.Size = new System.Drawing.Size(146, 15);
            this.lbSupplierDicari.TabIndex = 0;
            this.lbSupplierDicari.Text = "Nama Supplier yang dicari";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(164, 6);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.Size = new System.Drawing.Size(234, 23);
            this.tbNamaSupplier.TabIndex = 1;
            this.tbNamaSupplier.TextChanged += new System.EventHandler(this.tbNamaSupplier_TextChanged);
            this.tbNamaSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaSupplier_KeyDown);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSupplier.Location = new System.Drawing.Point(12, 35);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowTemplate.Height = 25;
            this.dgvSupplier.Size = new System.Drawing.Size(386, 143);
            this.dgvSupplier.TabIndex = 2;
            this.dgvSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSupplier_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeSupplier";
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaSupplier";
            this.Column2.HeaderText = "Nama Supplier";
            this.Column2.Name = "Column2";
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "kota";
            this.Column3.HeaderText = "Kota";
            this.Column3.Name = "Column3";
            // 
            // FormCariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 192);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.tbNamaSupplier);
            this.Controls.Add(this.lbSupplierDicari);
            this.Name = "FormCariSupplier";
            this.Text = "FormCariSupplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCariSupplier_FormClosed);
            this.Load += new System.EventHandler(this.FormCariSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSupplierDicari;
        private TextBox tbNamaSupplier;
        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}