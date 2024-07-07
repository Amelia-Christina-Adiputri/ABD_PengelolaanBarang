using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBarang
{
    public partial class FormCariBarang : Form
    {
        Tabel barang = new Tabel("barang");
        public FormCariBarang()
        {
            InitializeComponent();
        }

        private void FormCariBarang_Load(object sender, EventArgs e)
        {
            dgvBarang.DataSource = barang.getBs();
        }

        private void tbNamaBarang_TextChanged(object sender, EventArgs e)
        {
            barang.getBs().Filter = "namaBarang LIKE '%" +
                tbNamaBarang.Text + "%'";
        }

        private void tbNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                dgvBarang.Focus();
            }
        }

        private String _kodeBarang;
        public String kodeBarang
        {
            get
            {
                return this._kodeBarang;
            }
        }

        private void dgvBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int brs = dgvBarang.SelectedCells[0].RowIndex;
                this._kodeBarang = dgvBarang.Rows[brs].Cells[0].Value.ToString();
                this.Visible = false;
            }
        }

        private void FormCariBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            int brs = dgvBarang.SelectedCells[0].RowIndex;
            this._kodeBarang = dgvBarang.Rows[brs].Cells[0].Value.ToString();
        }
    }
}
