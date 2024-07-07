namespace WinFormsBarang
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.tbTelpon = new System.Windows.Forms.TextBox();
            this.lbTelpon = new System.Windows.Forms.Label();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.lbKota = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.tbNmSup = new System.Windows.Forms.TextBox();
            this.tbKdSup = new System.Windows.Forms.TextBox();
            this.lbNmSup = new System.Windows.Forms.Label();
            this.lbKdSup = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(12, 103);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowTemplate.Height = 25;
            this.dgvSupplier.Size = new System.Drawing.Size(776, 245);
            this.dgvSupplier.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga Beli";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(738, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 49;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(682, 391);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.TabIndex = 48;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(626, 391);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(514, 391);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(50, 50);
            this.btnUndo.TabIndex = 46;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(458, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 45;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(570, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(514, 391);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(458, 391);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 42;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(180, 391);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 50);
            this.btnLast.TabIndex = 41;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(124, 391);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 40;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(68, 391);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 39;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.Location = new System.Drawing.Point(12, 391);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(50, 50);
            this.btnTop.TabIndex = 37;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // tbTelpon
            // 
            this.tbTelpon.Enabled = false;
            this.tbTelpon.Location = new System.Drawing.Point(626, 12);
            this.tbTelpon.Name = "tbTelpon";
            this.tbTelpon.Size = new System.Drawing.Size(63, 23);
            this.tbTelpon.TabIndex = 34;
            // 
            // lbTelpon
            // 
            this.lbTelpon.AutoSize = true;
            this.lbTelpon.Location = new System.Drawing.Point(577, 15);
            this.lbTelpon.Name = "lbTelpon";
            this.lbTelpon.Size = new System.Drawing.Size(42, 15);
            this.lbTelpon.TabIndex = 33;
            this.lbTelpon.Text = "Telpon";
            // 
            // tbKota
            // 
            this.tbKota.Enabled = false;
            this.tbKota.Location = new System.Drawing.Point(438, 41);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(126, 23);
            this.tbKota.TabIndex = 32;
            // 
            // lbKota
            // 
            this.lbKota.AutoSize = true;
            this.lbKota.Location = new System.Drawing.Point(371, 44);
            this.lbKota.Name = "lbKota";
            this.lbKota.Size = new System.Drawing.Size(31, 15);
            this.lbKota.TabIndex = 31;
            this.lbKota.Text = "Kota";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Enabled = false;
            this.tbAlamat.Location = new System.Drawing.Point(438, 9);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(126, 23);
            this.tbAlamat.TabIndex = 30;
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(371, 12);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(45, 15);
            this.lbAlamat.TabIndex = 29;
            this.lbAlamat.Text = "Alamat";
            // 
            // tbNmSup
            // 
            this.tbNmSup.Enabled = false;
            this.tbNmSup.Location = new System.Drawing.Point(97, 41);
            this.tbNmSup.Name = "tbNmSup";
            this.tbNmSup.Size = new System.Drawing.Size(268, 23);
            this.tbNmSup.TabIndex = 28;
            // 
            // tbKdSup
            // 
            this.tbKdSup.Enabled = false;
            this.tbKdSup.Location = new System.Drawing.Point(97, 9);
            this.tbKdSup.Name = "tbKdSup";
            this.tbKdSup.Size = new System.Drawing.Size(100, 23);
            this.tbKdSup.TabIndex = 27;
            // 
            // lbNmSup
            // 
            this.lbNmSup.AutoSize = true;
            this.lbNmSup.Location = new System.Drawing.Point(12, 44);
            this.lbNmSup.Name = "lbNmSup";
            this.lbNmSup.Size = new System.Drawing.Size(85, 15);
            this.lbNmSup.TabIndex = 26;
            this.lbNmSup.Text = "Nama Supplier";
            // 
            // lbKdSup
            // 
            this.lbKdSup.AutoSize = true;
            this.lbKdSup.Location = new System.Drawing.Point(12, 12);
            this.lbKdSup.Name = "lbKdSup";
            this.lbKdSup.Size = new System.Drawing.Size(80, 15);
            this.lbKdSup.TabIndex = 25;
            this.lbKdSup.Text = "Kode Supplier";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.tbTelpon);
            this.Controls.Add(this.lbTelpon);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.lbKota);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.tbNmSup);
            this.Controls.Add(this.tbKdSup);
            this.Controls.Add(this.lbNmSup);
            this.Controls.Add(this.lbKdSup);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private Button btnClose;
        private Button btnPrint;
        private Button btnSearch;
        private Button btnUndo;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrev;
        private Button btnTop;
        private TextBox tbTelpon;
        private Label lbTelepon;
        private TextBox tbKota;
        private Label lbKota;
        private TextBox tbAlamat;
        private Label lbAlamat;
        private TextBox tbNmSup;
        private TextBox tbKdSup;
        private Label lbNmSup;
        private Label lbKdSup;
        private DataGridViewTextBoxColumn Column2;
        private Label lbTelpon;
    }
}