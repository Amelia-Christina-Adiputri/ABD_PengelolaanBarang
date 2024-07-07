using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBarang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public static bool barang = false;
        public static bool supplier = false;
        public static bool pembelian = false;
        public static string username= "";
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [user] where " +
                "userName = '" + tbUserName.Text + "' " +
                " and password = '" + tbPassword.Text+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                barang = bool.Parse(dr["barang"].ToString());
                supplier = bool.Parse(dr["supplier"].ToString());
                pembelian = bool.Parse(dr["pembelian"].ToString());
                username = dr["username"].ToString();
                FormUtama frm = new FormUtama();
                frm.ShowDialog();
                MessageBox.Show(dr["username"].ToString());
            }
            else
            {
                MessageBox.Show("username / password salah");
                tbUserName.Focus();
                tbUserName.Text = "";
                tbPassword.Text = "";
            }
            dr.Dispose();
            con.Close();
        }
    }
}
