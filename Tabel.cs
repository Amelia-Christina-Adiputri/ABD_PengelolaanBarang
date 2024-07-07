using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBarang
{
    internal class Tabel
    {
        String namaTabel;
        DataTable dt;
        BindingSource bs;

        public Tabel(string namaTabel)
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            this.isiDataTable();
            this.bs.DataSource = this.dt;
        }

        public void isiDataTable()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; " +
                "integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + this.namaTabel, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            this.dt.Clear();
            da.Fill(this.dt);
            this.bs.DataSource = this.dt;
            con.Close();
        }

        public void eksekusiSql(String sqlString)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; " +
                "integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.isiDataTable();
        }

        public String eksekusiSql_getID(String sqlString)
        {
            string nomorBaru = "";
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = inventory_b; " +
                "integrated security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT @@identity", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            nomorBaru = dr.GetValue(0).ToString();
            con.Close();
            this.isiDataTable();
            return nomorBaru;
        }

        public BindingSource getBs()
        {
            return this.bs;
        }

    }

}
