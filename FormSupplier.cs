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
    public partial class FormSupplier : Form
    {
        Boolean baru;
        String kdLama;
        Tabel supplier = new Tabel("supplier");

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = this.supplier.getBs();
            modeSave();
        }

        private void ikat()
        {
            tbKdSup.DataBindings.Add("Text", supplier.getBs(), "kodeSupplier");
            tbNmSup.DataBindings.Add("Text", supplier.getBs(), "namaSupplier");
            tbAlamat.DataBindings.Add("Text", supplier.getBs(), "alamat");
            tbKota.DataBindings.Add("Text", supplier.getBs(), "kota");
            tbTelpon.DataBindings.Add("Text", supplier.getBs(), "telpon");
        }

        private void lepas()
        {
            tbKdSup.DataBindings.Clear();
            tbNmSup.DataBindings.Clear();
            tbAlamat.DataBindings.Clear();
            tbKota.DataBindings.Clear();
            tbTelpon.DataBindings.Clear();
        }

        private void modeEdit()
        {
            tbKdSup.Enabled = true;
            tbNmSup.Enabled = true;
            tbAlamat.Enabled = true;
            tbKota.Enabled = true;
            tbTelpon.Enabled = true;
            tbKdSup.Focus();

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
            tbKdSup.Enabled = false;
            tbNmSup.Enabled = false;
            tbAlamat.Enabled = false;
            tbKota.Enabled = false;
            tbTelpon.Enabled = false;

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

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveNext();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, kode, nama, alamat, kota, telpon;
            kode = tbKdSup.Text;
            nama = tbNmSup.Text;
            alamat = tbAlamat.Text;
            kota = tbKota.Text;
            telpon = tbTelpon.Text;
            if (baru)
            {
                stringSQL = "INSERT INTO supplier VALUES('{0}','{1}','{2}','{3}',";
                stringSQL += "'{4}')";
                stringSQL = String.Format(stringSQL, kode, nama, alamat, kota,
                telpon);
            }
            else
            {
                stringSQL = "UPDATE supplier SET kodeSupplier = '{0}', namaSupplier = '{1}', alamat = '{2}', kota = '{3}', telpon= '{4}' WHERE kodeSupplier='{5}'";
                stringSQL = String.Format(stringSQL, kode, nama, alamat, kota,
                telpon, this.kdLama);
            }
            this.supplier.eksekusiSql(stringSQL);
            supplier.isiDataTable();
            modeSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM supplier WHERE kodeSupplier='{0}'";
                stringSQL = string.Format(stringSQL, tbKdSup.Text);
                MessageBox.Show("Periksa dulu : " + stringSQL);
                this.supplier.eksekusiSql(stringSQL);
                MessageBox.Show("Penghapusan selesai dilaksanakan..."); //<-- feedback
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan..."); //<-- feedback
            }
            supplier.isiDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            baru = true;
            tbKdSup.Text = null;
            tbNmSup.Text = null;
            tbAlamat.Text = null;
            tbKota.Text = null;
            tbTelpon.Text = null;
            modeEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            baru = false;
            kdLama = tbKdSup.Text;
            modeEdit();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }
    }
}