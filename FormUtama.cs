using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBarang
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            barangToolStripMenuItem.Enabled = FormLogin.barang;
            supplierToolStripMenuItem.Enabled = FormLogin.supplier;
            pembelianToolStripMenuItem.Enabled = FormLogin.pembelian;
            lbUser.Text = "Username: " + "["+FormLogin.username+"]";
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataBarang frm = new FormDataBarang();
            frm.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier frm = new FormSupplier();
            frm.ShowDialog();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaBeli frm = new FormNotaBeli();
            frm.ShowDialog();
        }
    }
}
