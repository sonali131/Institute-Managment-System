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

namespace Institute_MS
{
    public partial class Update_Course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Update_Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string Cid = comboBox2.Text;
            string Cname = comboBox1.Text;
            string Duration = textBox2.Text;
            
            string qr = "update Course set Course_Id='" + comboBox2.Text + "',Course_Name='" + comboBox1.Text + "',Duration='" + textBox2.Text + "'where Course_Id='" + comboBox2.Text + "' ";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Record is Updated successfuly!!");
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Course where Course_Id='" + comboBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd[1].ToString();
                string Duration= rd[2].ToString();
                comboBox1.Text = Cname;
                textBox2.Text = Duration;
            }
            
            con.Close();
        }

        private void Update_Course_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add((ds.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();
        }
    }
}
