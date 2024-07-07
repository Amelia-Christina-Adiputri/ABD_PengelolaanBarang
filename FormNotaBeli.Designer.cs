namespace WinFormsBarang
{
    partial class FormNotaBeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaBeli));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNoNotaBeli = new System.Windows.Forms.TextBox();
            this.lbNoNotaBeli = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTop = new System.Windows.Forms.Button();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.lbKota = new System.Windows.Forms.Label();
            this.tbTelpon = new System.Windows.Forms.TextBox();
            this.lbtelpon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.lbKodeSupplier = new System.Windows.Forms.Label();
            this.lbNamaSupplier = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.tbKodeSupplier = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbItemDataEntry = new System.Windows.Forms.GroupBox();
            this.lbJumlah = new System.Windows.Forms.Label();
            this.lbKodeBarang = new System.Windows.Forms.Label();
            this.lbNamaBarang = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.lbQty = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lbHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbItemDataEntry.SuspendLayout();
            this.SuspendLayout();
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
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // tbNoNotaBeli
            // 
            this.tbNoNotaBeli.Location = new System.Drawing.Point(97, 12);
            this.tbNoNotaBeli.Name = "tbNoNotaBeli";
            this.tbNoNotaBeli.ReadOnly = true;
            this.tbNoNotaBeli.Size = new System.Drawing.Size(100, 23);
            this.tbNoNotaBeli.TabIndex = 51;
            this.tbNoNotaBeli.TextChanged += new System.EventHandler(this.tbNoNotaBeli_TextChanged);
            // 
            // lbNoNotaBeli
            // 
            this.lbNoNotaBeli.AutoSize = true;
            this.lbNoNotaBeli.Location = new System.Drawing.Point(12, 15);
            this.lbNoNotaBeli.Name = "lbNoNotaBeli";
            this.lbNoNotaBeli.Size = new System.Drawing.Size(77, 15);
            this.lbNoNotaBeli.TabIndex = 50;
            this.lbNoNotaBeli.Text = "No. Nota Beli";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(625, 12);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.ReadOnly = true;
            this.tbTanggal.Size = new System.Drawing.Size(127, 23);
            this.tbTanggal.TabIndex = 53;
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Location = new System.Drawing.Point(558, 15);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(48, 15);
            this.lbTanggal.TabIndex = 52;
            this.lbTanggal.Text = "Tanggal";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(737, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 81;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(681, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(625, 554);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 79;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(457, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 77;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(569, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(513, 554);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(457, 554);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.TabIndex = 74;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(179, 554);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 50);
            this.btnLast.TabIndex = 73;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(123, 554);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 72;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(67, 554);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 71;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDetail.Location = new System.Drawing.Point(11, 266);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowTemplate.Height = 25;
            this.dgvDetail.Size = new System.Drawing.Size(776, 239);
            this.dgvDetail.TabIndex = 70;
            this.dgvDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetail_KeyDown);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "idNotaBeli";
            this.Column10.HeaderText = "IdNotaBeli";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "noNotaBeli";
            this.Column4.HeaderText = "NoBotaBeli";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "kodeBarang";
            this.Column5.HeaderText = "Kode";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "namaBarang";
            this.Column6.HeaderText = "Nama Barang";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "qty";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "harga";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Harga";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "jumlah";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.HeaderText = "Jumlah";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // btnTop
            // 
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.Location = new System.Drawing.Point(11, 554);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(50, 50);
            this.btnTop.TabIndex = 69;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(613, 85);
            this.tbKota.Name = "tbKota";
            this.tbKota.ReadOnly = true;
            this.tbKota.Size = new System.Drawing.Size(163, 23);
            this.tbKota.TabIndex = 64;
            // 
            // lbKota
            // 
            this.lbKota.AutoSize = true;
            this.lbKota.Location = new System.Drawing.Point(546, 88);
            this.lbKota.Name = "lbKota";
            this.lbKota.Size = new System.Drawing.Size(31, 15);
            this.lbKota.TabIndex = 63;
            this.lbKota.Text = "Kota";
            // 
            // tbTelpon
            // 
            this.tbTelpon.Location = new System.Drawing.Point(613, 53);
            this.tbTelpon.Name = "tbTelpon";
            this.tbTelpon.ReadOnly = true;
            this.tbTelpon.Size = new System.Drawing.Size(126, 23);
            this.tbTelpon.TabIndex = 62;
            // 
            // lbtelpon
            // 
            this.lbtelpon.AutoSize = true;
            this.lbtelpon.Location = new System.Drawing.Point(546, 56);
            this.lbtelpon.Name = "lbtelpon";
            this.lbtelpon.Size = new System.Drawing.Size(42, 15);
            this.lbtelpon.TabIndex = 61;
            this.lbtelpon.Text = "Telpon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAlamat);
            this.groupBox1.Controls.Add(this.lbKodeSupplier);
            this.groupBox1.Controls.Add(this.lbNamaSupplier);
            this.groupBox1.Controls.Add(this.tbNamaSupplier);
            this.groupBox1.Controls.Add(this.tbKodeSupplier);
            this.groupBox1.Controls.Add(this.tbAlamat);
            this.groupBox1.Controls.Add(this.tbKota);
            this.groupBox1.Controls.Add(this.lbtelpon);
            this.groupBox1.Controls.Add(this.tbTelpon);
            this.groupBox1.Controls.Add(this.lbKota);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 111);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier:";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(-1, 88);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(45, 15);
            this.lbAlamat.TabIndex = 92;
            this.lbAlamat.Text = "Alamat";
            // 
            // lbKodeSupplier
            // 
            this.lbKodeSupplier.AutoSize = true;
            this.lbKodeSupplier.Location = new System.Drawing.Point(-1, 22);
            this.lbKodeSupplier.Name = "lbKodeSupplier";
            this.lbKodeSupplier.Size = new System.Drawing.Size(34, 15);
            this.lbKodeSupplier.TabIndex = 91;
            this.lbKodeSupplier.Text = "Kode";
            // 
            // lbNamaSupplier
            // 
            this.lbNamaSupplier.AutoSize = true;
            this.lbNamaSupplier.Location = new System.Drawing.Point(0, 56);
            this.lbNamaSupplier.Name = "lbNamaSupplier";
            this.lbNamaSupplier.Size = new System.Drawing.Size(39, 15);
            this.lbNamaSupplier.TabIndex = 90;
            this.lbNamaSupplier.Text = "Nama";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(85, 53);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.ReadOnly = true;
            this.tbNamaSupplier.Size = new System.Drawing.Size(410, 23);
            this.tbNamaSupplier.TabIndex = 89;
            // 
            // tbKodeSupplier
            // 
            this.tbKodeSupplier.Location = new System.Drawing.Point(85, 19);
            this.tbKodeSupplier.Name = "tbKodeSupplier";
            this.tbKodeSupplier.ReadOnly = true;
            this.tbKodeSupplier.Size = new System.Drawing.Size(100, 23);
            this.tbKodeSupplier.TabIndex = 88;
            this.tbKodeSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKodeSupplier_KeyUp);
            this.tbKodeSupplier.Validated += new System.EventHandler(this.tbKodeSupplier_Validated);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(85, 85);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.ReadOnly = true;
            this.tbAlamat.Size = new System.Drawing.Size(410, 23);
            this.tbAlamat.TabIndex = 87;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(625, 512);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(162, 23);
            this.tbTotal.TabIndex = 85;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(558, 515);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(32, 15);
            this.lbTotal.TabIndex = 65;
            this.lbTotal.Text = "Total";
            // 
            // gbItemDataEntry
            // 
            this.gbItemDataEntry.Controls.Add(this.lbJumlah);
            this.gbItemDataEntry.Controls.Add(this.lbKodeBarang);
            this.gbItemDataEntry.Controls.Add(this.lbNamaBarang);
            this.gbItemDataEntry.Controls.Add(this.tbNamaBarang);
            this.gbItemDataEntry.Controls.Add(this.tbKodeBarang);
            this.gbItemDataEntry.Controls.Add(this.tbJumlah);
            this.gbItemDataEntry.Controls.Add(this.tbHarga);
            this.gbItemDataEntry.Controls.Add(this.lbQty);
            this.gbItemDataEntry.Controls.Add(this.tbQty);
            this.gbItemDataEntry.Controls.Add(this.lbHarga);
            this.gbItemDataEntry.Location = new System.Drawing.Point(11, 165);
            this.gbItemDataEntry.Name = "gbItemDataEntry";
            this.gbItemDataEntry.Size = new System.Drawing.Size(776, 75);
            this.gbItemDataEntry.TabIndex = 93;
            this.gbItemDataEntry.TabStop = false;
            this.gbItemDataEntry.Text = "Item Data Entry";
            // 
            // lbJumlah
            // 
            this.lbJumlah.AutoSize = true;
            this.lbJumlah.Location = new System.Drawing.Point(614, 19);
            this.lbJumlah.Name = "lbJumlah";
            this.lbJumlah.Size = new System.Drawing.Size(45, 15);
            this.lbJumlah.TabIndex = 92;
            this.lbJumlah.Text = "Jumlah";
            // 
            // lbKodeBarang
            // 
            this.lbKodeBarang.AutoSize = true;
            this.lbKodeBarang.Location = new System.Drawing.Point(44, 19);
            this.lbKodeBarang.Name = "lbKodeBarang";
            this.lbKodeBarang.Size = new System.Drawing.Size(34, 15);
            this.lbKodeBarang.TabIndex = 91;
            this.lbKodeBarang.Text = "Kode";
            // 
            // lbNamaBarang
            // 
            this.lbNamaBarang.AutoSize = true;
            this.lbNamaBarang.Location = new System.Drawing.Point(146, 19);
            this.lbNamaBarang.Name = "lbNamaBarang";
            this.lbNamaBarang.Size = new System.Drawing.Size(79, 15);
            this.lbNamaBarang.TabIndex = 90;
            this.lbNamaBarang.Text = "Nama Barang";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(146, 40);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(246, 23);
            this.tbNamaBarang.TabIndex = 89;
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Location = new System.Drawing.Point(44, 40);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(96, 23);
            this.tbKodeBarang.TabIndex = 88;
            this.tbKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKodeBarang_KeyUp);
            this.tbKodeBarang.Validated += new System.EventHandler(this.tbKodeBarang_Validated);
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(614, 40);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(144, 23);
            this.tbJumlah.TabIndex = 87;
            this.tbJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJumlah_KeyDown);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(464, 40);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(144, 23);
            this.tbHarga.TabIndex = 64;
            this.tbHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHarga_KeyDown);
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            this.tbHarga.Validated += new System.EventHandler(this.tbHarga_Validated);
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(398, 19);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(26, 15);
            this.lbQty.TabIndex = 61;
            this.lbQty.Text = "Qty";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(398, 40);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(60, 23);
            this.tbQty.TabIndex = 62;
            this.tbQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQty_KeyDown);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            this.tbQty.Validated += new System.EventHandler(this.tbQty_Validated);
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Location = new System.Drawing.Point(464, 19);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(39, 15);
            this.lbHarga.TabIndex = 63;
            this.lbHarga.Text = "Harga";
            // 
            // FormNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.lbTanggal);
            this.Controls.Add(this.tbNoNotaBeli);
            this.Controls.Add(this.lbNoNotaBeli);
            this.Controls.Add(this.gbItemDataEntry);
            this.Name = "FormNotaBeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotaBeli";
            this.Load += new System.EventHandler(this.FormNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbItemDataEntry.ResumeLayout(false);
            this.gbItemDataEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox tbNoNotaBeli;
        private Label lbNoNotaBeli;
        private TextBox tbTanggal;
        private Label lbTanggal;
        private Button btnClose;
        private Button btnPrint;
        private Button btnSearch;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrev;
        private DataGridView dgvDetail;
        private Button btnTop;
        private TextBox tbKota;
        private Label lbKota;
        private TextBox tbTelpon;
        private Label lbtelpon;
        private GroupBox groupBox1;
        private TextBox tbTotal;
        private Label lbTotal;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Label lbAlamat;
        private Label lbKodeSupplier;
        private Label lbNamaSupplier;
        private TextBox tbNamaSupplier;
        private TextBox tbKodeSupplier;
        private TextBox tbAlamat;
        private GroupBox gbItemDataEntry;
        private Label lbJumlah;
        private Label lbKodeBarang;
        private Label lbNamaBarang;
        private TextBox tbNamaBarang;
        private TextBox tbKodeBarang;
        private TextBox tbJumlah;
        private TextBox tbHarga;
        private Label lbQty;
        private TextBox tbQty;
        private Label lbHarga;
    }
}