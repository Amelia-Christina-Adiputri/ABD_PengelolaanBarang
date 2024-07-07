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
    public partial class FormNotaBeli : Form
    {
        public FormNotaBeli()
        {
            InitializeComponent();
        }

        Tabel master = new Tabel("v_Nota_Beli");
        Tabel detail = new Tabel("v_Item_Nota_Beli");

        void ikat()
        {
            tbNoNotaBeli.DataBindings.Add("Text", master.getBs(), "noNotaBeli");
            tbTanggal.DataBindings.Add("Text", master.getBs(), "tanggal");
            tbKodeSupplier.DataBindings.Add("Text", master.getBs(), "kodeSupplier");
            tbNamaSupplier.DataBindings.Add("Text", master.getBs(), "namaSupplier");
            tbAlamat.DataBindings.Add("Text", master.getBs(), "alamat");
            tbTelpon.DataBindings.Add("Text", master.getBs(), "telpon");
            tbKota.DataBindings.Add("Text", master.getBs(), "kota");
            dgvDetail.DataSource = detail.getBs();
        }

        void modeEdit()
        {
            tbKodeSupplier.ReadOnly = false;
            dgvDetail.Top = 240;
            dgvDetail.Height = 260;
            tbKodeSupplier.Focus();
            btnSave.Visible = true;
            btnEdit.Enabled = false;
            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnPrint.Enabled = false;
            btnClose.Enabled = false;
        }

        void modeSave()
        {
            tbKodeSupplier.ReadOnly = true;
            dgvDetail.Top = 165;
            dgvDetail.Height = 340;
            btnSave.Visible = false;
            btnEdit.Enabled = true;
            btnTop.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnDelete.Enabled = true;
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
            btnClose.Enabled = true;
        }

        void tampil()
        {
            detail.getBs().Filter = "noNotaBeli=" + tbNoNotaBeli.Text;
            total();
        }

        void total()
        {
            int baris, total = 0;
            for (baris = 0; baris < dgvDetail.Rows.Count; baris++)
            {
                total += int.Parse(dgvDetail.Rows[baris].Cells[6].Value.ToString());
            }
            tbTotal.Text = total.ToString("#,###");
        }

        void hapus()
        {
            tbKodeBarang.Clear();
            tbNamaBarang.Clear();
            tbQty.Text = "0";
            tbHarga.Text = "0";
            tbJumlah.Text = "0";
            tbKodeBarang.Focus();
        }

        private void FormNotaBeli_Load(object sender, EventArgs e)
        {
            ikat();
            tampil();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveFirst();
            tampil();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            tampil();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String tgl = DateTime.Now.ToString("yyyy/MM/dd");
            String strSQL = "INSERT INTO notaBeli(tanggal) VALUES('" + tgl + "')";
            String nomornya = master.eksekusiSql_getID(strSQL);
            int baris = master.getBs().Find("noNotaBeli", nomornya);
            master.getBs().Position = baris;
            tampil();
            modeEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult jwb = MessageBox.Show("Yakin menghapus?","Konfirmasi",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(jwb == DialogResult.Yes)
            {
                string noNotaBeli = tbNoNotaBeli.Text;
                string strSQL = "DELETE FROM itemNotaBeli WHERE noNotaBeli = " + noNotaBeli;
                detail.eksekusiSql(strSQL);
                strSQL = "DELETE FROM notaBeli WHERE noNotaBeli = " + noNotaBeli;
                master.eksekusiSql(strSQL);
                MessageBox.Show("Penghapusan Selesai...");
                master.getBs().MoveLast();
            }
            else
            {
                MessageBox.Show("Penghapusan Dibatalkan...");
            }
        }

        private void tbKodeBarang_Validated(object sender, EventArgs e)
        {
            Tabel barang = new Tabel("Barang");
            if (tbKodeBarang.Text.Length > 0)
            {
                int ketemu = barang.getBs().Find("kodeBarang", tbKodeBarang.Text);
                if (ketemu >= 0)
                {
                    barang.getBs().Position = ketemu;
                    tbNamaBarang.Text = ((DataRowView)barang.getBs().Current).Row["namaBarang"].ToString();
                    tbHarga.Text = ((DataRowView)barang.getBs().Current).Row["hargaBeli"].ToString();
                }
                else
                {
                    MessageBox.Show("Kode " + tbKodeBarang.Text + " tidak terdaftar...");
                    hapus();
                }
            }
        }

        private void tbKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 191)
            {
                FormCariBarang frmCs = new FormCariBarang();
                frmCs.ShowDialog();
                tbKodeSupplier.Text = frmCs.kodeBarang;
                frmCs.Dispose();
            }
            if (tbKodeBarang.Text.Length == 5)
                tbQty.Focus();
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbQty_Validated(object sender, EventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQty.Text) * int.Parse(tbHarga.Text)).ToString();
        }

        private void tbHarga_Validated(object sender, EventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQty.Text) * int.Parse(tbHarga.Text)).ToString();
        }

        private void tbQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbQty.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(tbQty.Text) > 0)
                {
                    tbHarga.Focus();
                }
            }
        }

        private void tbHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbHarga.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(tbHarga.Text) > 0)
                {
                    tbJumlah.Focus();
                }
            }
        }

        private void tbJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbJumlah.Text.Length > 0)
            {
                string noNotaBeli, kodeBarang, qty, harga, strSQL;
                noNotaBeli = tbNoNotaBeli.Text;
                kodeBarang = tbKodeBarang.Text;
                qty = tbQty.Text;
                harga = tbHarga.Text;
                strSQL = "INSERT INTO itemNotaBeli(noNotaBeli, kodeBarang, qty, harga) VALUES('{0}', '{1}', '{2}', '{3}')";
                strSQL = String.Format(strSQL, noNotaBeli, kodeBarang, qty, harga);
                detail.eksekusiSql(strSQL);
                hapus();
                total();
            }
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvDetail.SelectedCells[0].RowIndex;
            if (e.KeyData == Keys.Back)
            {
                modeEdit();
                tbKodeBarang.Text = dgvDetail.Rows[baris].Cells[0].Value.ToString();
                tbNamaBarang.Text = dgvDetail.Rows[baris].Cells[4].Value.ToString();
                tbQty.Text = dgvDetail.Rows[baris].Cells[3].Value.ToString();
                tbHarga.Text = dgvDetail.Rows[baris].Cells[5].Value.ToString();
                tbJumlah.Text = dgvDetail.Rows[baris].Cells[6].Value.ToString();
                string idNotaBeli = dgvDetail.Rows[baris].Cells[1].Value.ToString();
                string strSQL = "DELETE from itemNotaBeli WHERE idNotaBeli= " + idNotaBeli;
                detail.eksekusiSql(strSQL);
                total();
            }

            if (e.KeyData == Keys.Delete)
            {
                string idNotaBeli = dgvDetail.Rows[baris].Cells[1].Value.ToString();
                string strSQL = "DELETE from itemNotaBeli WHERE idNotaBeli= " + idNotaBeli;
                detail.eksekusiSql(strSQL);
                total();
            }
        }

        private void tbKodeSupplier_Validated(object sender, EventArgs e)
        {
            string noNotaBeli = tbNoNotaBeli.Text, strSQL;
            Tabel supplier = new Tabel("supplier");
            int noBaris = supplier.getBs().Find("kodeSupplier", tbKodeSupplier.Text);
            if (noBaris >= 0)
            {
                strSQL = "UPDATE notaBeli SET kodeSupplier = '{0}' WHERE noNotaBeli = '{1}'";
                strSQL = String.Format(strSQL, tbKodeSupplier.Text, noNotaBeli);
                tbKodeBarang.Focus();
            }
            else
            {
                MessageBox.Show("Kode Supplier Tidak Ditemukan!");
                strSQL = "UPDATE notaBeli SET kodeSupplier = NULL WHERE noNotaBeli = '{0}'";
                strSQL = String.Format(strSQL, noNotaBeli);
                if (tbKodeSupplier.Text.Length > 0)
                    tbKodeSupplier.Focus();
                else
                    tbKodeBarang.Focus();

                tbKodeBarang.Focus();
                tbKodeSupplier.Focus();
            }
            master.eksekusiSql(strSQL);
            noBaris = master.getBs().Find("noNotaBeli", noNotaBeli);
            master.getBs().Position = noBaris;
        }

        private void tbKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 191)
            {
                FormCariSupplier frmCs = new FormCariSupplier();
                frmCs.ShowDialog();
                tbKodeSupplier.Text = frmCs.kodeSupplier;
                frmCs.Dispose();
            }
            if (tbKodeSupplier.Text.Length == 3 || e.KeyCode == Keys.Enter)
            {
                tbKodeBarang.Focus();
            }
        }
        private void modeCari()
        {
            btnTop.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnPrint.Enabled = false;
            btnSearch.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            modeCari();
            String noNotaSekarang = tbNoNotaBeli.Text;
            String noNotaBeli;
            tbNoNotaBeli.Visible = true;
            master.getBs().MoveFirst();
            tbNoNotaBeli.Text = noNotaSekarang;
            for (int n = 0; n < master.getBs().Count; n++)
            {
                noNotaBeli = ((DataRowView)master.getBs().Current).Row["noNotaBeli"].ToString();
                master.getBs().MoveNext();
            }
            int posisi = master.getBs().Find("noNotaBeli", noNotaSekarang);
            master.getBs().Position = posisi;
            tbNoNotaBeli.Focus();
        }

        private void tbNoNotaBeli_TextChanged(object sender, EventArgs e)
        {
            master.getBs().Position = master.getBs().Find("noNotaBeli", tbNoNotaBeli.Text);
            tampil();
            tbNoNotaBeli.Visible = false;
            modeSave();
        }
    }
}