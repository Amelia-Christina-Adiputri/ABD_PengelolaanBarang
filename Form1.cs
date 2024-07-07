using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;

namespace WinFormsBarang
{
    public partial class FormDataBarang : Form
    {
        Boolean baru;
        String kdLama;

        public FormDataBarang()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            isiDataTable();
            ikat();  
        }

        void isiDataTable()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            bs.DataSource = dt; //<-- data table ditangani BindingSource
            dgvBarang.DataSource = bs; //<-- pakai BindingSource
        }

        private void modeEdit()
        {
            tbKdBrg.Enabled = true;
            tbNmBrg.Enabled = true;
            tbHrgBeli.Enabled = true;
            tbHrgJual.Enabled = true;
            tbStok.Enabled = true;
            tbSatuan.Enabled = true;
            tbKdBrg.Focus();

            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            btnUndo.Visible = true;
            btnClose.Enabled = false;
            lepas();
        }

        private void modeSave()
        {
            tbKdBrg.Enabled = false;
            tbNmBrg.Enabled = false;
            tbHrgBeli.Enabled = false;
            tbHrgJual.Enabled = false;
            tbStok.Enabled = false;
            tbSatuan.Enabled = false;

            btnTop.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnPrint.Enabled = true;
            btnSearch.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnUndo.Visible = false;
            btnClose.Enabled = true;
            ikat();
        }

        void ikat()
        {
            tbKdBrg.DataBindings.Add("Text", bs, "kodeBarang");
            tbNmBrg.DataBindings.Add("Text", bs, "namaBarang");
            tbHrgBeli.DataBindings.Add("Text", bs, "hargaBeli");
            tbHrgJual.DataBindings.Add("Text", bs, "hargaJual");
            tbStok.DataBindings.Add("Text", bs, "stok");
            tbSatuan.DataBindings.Add("Text", bs, "satuan");
        }

        void lepas()
        {
            tbKdBrg.DataBindings.Clear();
            tbNmBrg.DataBindings.Clear();
            tbHrgBeli.DataBindings.Clear();
            tbHrgJual.DataBindings.Clear();
            tbStok.DataBindings.Clear();
            tbSatuan.DataBindings.Clear();
        }

        void kirimSql(String sqlString)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            baru = true;
            tbKdBrg.Text = null;
            tbNmBrg.Text = null;
            tbHrgBeli.Text = null;
            tbHrgJual.Text = null;
            tbStok.Text = null;
            tbSatuan.Text = null;
            modeEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            baru = false;
            kdLama = tbKdBrg.Text;
            modeEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String kode, nama, beli, jual, stok, satuan;
            kode = tbKdBrg.Text;
            nama = tbNmBrg.Text;
            beli = tbHrgBeli.Text;
            jual = tbHrgJual.Text;
            stok = tbStok.Text;
            satuan = tbSatuan.Text;
            if (baru == true)
            {
                String sqlString = "INSERT INTO barang VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
                sqlString = String.Format(sqlString, kode, nama, beli, jual, stok, satuan);
                kirimSql(sqlString);
            }
            else
            {
                String sqlString = "UPDATE barang SET kodeBarang = '{0}', namaBarang = '{1}', hargaBeli = '{2}', hargaJual = '{3}', stok = '{4}', satuan = '{5}' WHERE kodeBarang = '{6}'";
                sqlString = String.Format(sqlString, kode, nama, beli, jual, stok, satuan, kdLama);
                kirimSql(sqlString);
            }
            modeSave();
            isiDataTable();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                String kd_hapus = tbKdBrg.Text;
                String strSQL = "DELETE FROM barang WHERE kodeBarang = '{0}'";
                strSQL = String.Format(strSQL, kd_hapus);
                kirimSql(strSQL);
                isiDataTable();
            } 
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //  Form2 frm2 = new Form2();
        //  frm2.Show();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //  Form3 frm2 = new Form3();
        //  frm2.Show();
        //}
    }
}