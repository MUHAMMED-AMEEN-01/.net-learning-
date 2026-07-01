using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\00muh\\OneDrive\\文档\\dbP1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from Student";
            cm.Connection = con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; 

        }
    }
}
