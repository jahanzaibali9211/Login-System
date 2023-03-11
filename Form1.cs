using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Login_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-AMM1MQ8C;Initial Catalog=Login;Integrated Security=True";
            con.Open();
            string userid = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select UserName,Password from LoginMst where UserName='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage http://itsourcecode.com");
                System.Diagnostics.Process.Start("http://itsourcecode.com");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-AMM1MQ8C;Initial Catalog=Login;Integrated Security=True");
            con.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
