﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_MS
{
    public partial class SearchStaff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public SearchStaff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string qr = "select * from Staff where Staff_Id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string qr = "select * from Staff where Name='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}