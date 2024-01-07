using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BSCIT.mdf;Integrated Security=True");
            //cn.Open();
            string sql = "select * from table1 where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            //SqlCommand cmd = new SqlCommand(sql, cn);
            //SqlDataReader dr = null;
            //dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dr.Close();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!");
            }
            //cn.Close();
        }
    }
}
