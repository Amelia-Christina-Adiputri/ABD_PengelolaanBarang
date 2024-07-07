namespace WinFormsBarang
{
    partial class FormDataBarang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBarang));
            this.lbKdBrg = new System.Windows.Forms.Label();
            this.lbNmBrg = new System.Windows.Forms.Label();
            this.tbKdBrg = new System.Windows.Forms.TextBox();
            this.tbNmBrg = new System.Windows.Forms.TextBox();
            this.lbHrgBeli = new System.Windows.Forms.Label();
            this.tbHrgBeli = new System.Windows.Forms.TextBox();
            this.lbHrgJual = new System.Windows.Forms.Label();
            this.tbHrgJual = new System.Windows.Forms.TextBox();
            this.lbStok = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.lbSatuan = new System.Windows.Forms.Label();
            this.tbSatuan = new System.Windows.Forms.TextBox();
            this.btnTop = new System.Windows.Forms.Button();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKdBrg
            // 
            this.lbKdBrg.AutoSize = true;
            this.lbKdBrg.Location = new System.Drawing.Point(12, 9);
            this.lbKdBrg.Name = "lbKdBrg";
            this.lbKdBrg.Size = new System.Drawing.Size(74, 15);
            this.lbKdBrg.TabIndex = 0;
            this.lbKdBrg.Text = "Kode Barang";
            // 
            // lbNmBrg
            // 
            this.lbNmBrg.AutoSize = true;
            this.lbNmBrg.Location = new System.Drawing.Point(12, 41);
            this.lbNmBrg.Name = "lbNmBrg";
            this.lbNmBrg.Size = new System.Drawing.Size(79, 15);
            this.lbNmBrg.TabIndex = 1;
            this.lbNmBrg.Text = "Nama Barang";
            // 
            // tbKdBrg
            // 
            this.tbKdBrg.Enabled = false;
            this.tbKdBrg.Location = new System.Drawing.Point(97, 6);
            this.tbKdBrg.Name = "tbKdBrg";
            this.tbKdBrg.Size = new System.Drawing.Size(100, 23);
            this.tbKdBrg.TabIndex = 2;
            // 
            // tbNmBrg
            // 
            this.tbNmBrg.Enabled = false;
            this.tbNmBrg.Location = new System.Drawing.Point(97, 38);
            this.tbNmBrg.Name = "tbNmBrg";
            this.tbNmBrg.Size = new System.Drawing.Size(268, 23);
            this.tbNmBrg.TabIndex = 3;
            // 
            // lbHrgBeli
            // 
            this.lbHrgBeli.AutoSize = true;
            this.lbHrgBeli.Location = new System.Drawing.Point(371, 9);
            this.lbHrgBeli.Name = "lbHrgBeli";
            this.lbHrgBeli.Size = new System.Drawing.Size(61, 15);
            this.lbHrgBeli.TabIndex = 4;
            this.lbHrgBeli.Text = "Harga Beli";
            // 
            // tbHrgBeli
            // 
            this.tbHrgBeli.Enabled = false;
            this.tbHrgBeli.Location = new System.Drawing.Point(438, 6);
            this.tbHrgBeli.Name = "tbHrgBeli";
            this.tbHrgBeli.Size = new System.Drawing.Size(126, 23);
            this.tbHrgBeli.TabIndex = 5;
            // 
            // lbHrgJual
            // 
            this.lbHrgJual.AutoSize = true;
            this.lbHrgJual.Location = new System.Drawing.Point(371, 41);
            this.lbHrgJual.Name = "lbHrgJual";
            this.lbHrgJual.Size = new System.Drawing.Size(62, 15);
            this.lbHrgJual.TabIndex = 6;
            this.lbHrgJual.Text = "Harga Jual";
            // 
            // tbHrgJual
            // 
            this.tbHrgJual.Enabled = false;
            this.tbHrgJual.Location = new System.Drawing.Point(438, 38);
            this.tbHrgJual.Name = "tbHrgJual";
            this.tbHrgJual.Size = new System.Drawing.Size(126, 23);
            this.tbHrgJual.TabIndex = 7;
            // 
            // lbStok
            // 
            this.lbStok.AutoSize = true;
            this.lbStok.Location = new System.Drawing.Point(577, 12);
            this.lbStok.Name = "lbStok";
            this.lbStok.Size = new System.Drawing.Size(30, 15);
            this.lbStok.TabIndex = 8;
            this.lbStok.Text = "Stok";
            // 
            // tbStok
            // 
            this.tbStok.Enabled = false;
            this.tbStok.Location = new System.Drawing.Point(626, 9);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(63, 23);
            this.tbStok.TabIndex = 9;
            // 
            // lbSatuan
            // 
            this.lbSatuan.AutoSize = true;
            this.lbSatuan.Location = new System.Drawing.Point(577, 44);
            this.lbSatuan.Name = "lbSatuan";
            this.lbSatuan.Size = new System.Drawing.Size(43, 15);
            this.lbSatuan.TabIndex = 10;
            this.lbSatuan.Text = "Satuan";
            // 
            // tbSatuan
            // 
            this.tbSatuan.Enabled = false;
            this.tbSatuan.Location = new System.Drawing.Point(626, 41);
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.Size = new System.Drawing.Size(161, 23);
            this.tbSatuan.TabIndex = 11;
            // 
            // btnTop
            // 
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.Location = new System.Drawing.Point(12, 388);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(50, 50);
            this.btnTop.TabIndex = 12;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvBarang.Location = new System.Drawing.Point(12, 67);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowTemplate.Height = 25;
            this.dgvBarang.Size = new System.Drawing.Size(776, 315);
            this.dgvBarang.TabIndex = 13;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "kodeBarang";
            this.Column4.HeaderText = "Kode";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "namaBarang";
            this.Column5.HeaderText = "Nama Barang";
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "hargaBeli";
            this.Column6.HeaderText = "Harga Beli";
            this.Column6.Name = "Column6";
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hargaJual";
            this.Column7.HeaderText = "Harga Jual";
            this.Column7.Name = "Column7";
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "stok";
            this.Column8.HeaderText = "Stok";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "satuan";
            this.Column9.HeaderText = "Satuan";
            this.Column9.Name = "Column9";
            this.Column9.Width = 143;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(68, 388);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(124, 388);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(180, 388);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 50);
            this.btnLast.TabIndex = 16;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(458, 388);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 17;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(514, 388);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(570, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(458, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(514, 388);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(50, 50);
            this.btnUndo.TabIndex = 21;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(626, 388);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(682, 388);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(738, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga Beli";
            this.Column3.Name = "Column3";
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
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
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.tbSatuan);
            this.Controls.Add(this.lbSatuan);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.lbStok);
            this.Controls.Add(this.tbHrgJual);
            this.Controls.Add(this.lbHrgJual);
            this.Controls.Add(this.tbHrgBeli);
            this.Controls.Add(this.lbHrgBeli);
            this.Controls.Add(this.tbNmBrg);
            this.Controls.Add(this.tbKdBrg);
            this.Controls.Add(this.lbNmBrg);
            this.Controls.Add(this.lbKdBrg);
            this.Name = "FormDataBarang";
            this.Text = "Form Data Barang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbKdBrg;
        private Label lbNmBrg;
        private TextBox tbKdBrg;
        private TextBox tbNmBrg;
        private Label lbHrgBeli;
        private TextBox tbHrgBeli;
        private Label lbHrgJual;
        private TextBox tbHrgJual;
        private Label lbStok;
        private TextBox tbStok;
        private Label lbSatuan;
        private TextBox tbSatuan;
        private Button btnTop;
        private DataGridView dgvBarang;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUndo;
        private Button btnSearch;
        private Button btnPrint;
        private Button btnClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}