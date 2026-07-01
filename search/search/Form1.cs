using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dis(textBox1.Text);
        }

        void dis(string se){
            SqlConnection con = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\00muh\\OneDrive\\文档\\dbP1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cm.CommandText = "select * from Student where Name like '" + se + "%'";
            cm.Connection = con;
            da.SelectCommand = cm;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
