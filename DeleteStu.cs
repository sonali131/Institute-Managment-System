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
    public partial class DeleteStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        string img;
        public DeleteStu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Student where Stu_Id='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string sname = rd[1].ToString();
                DateTime dob = Convert.ToDateTime(rd[4].ToString());
                img = rd[14].ToString();

                textBox1.Text = sname;
                pictureBox1.Image = new Bitmap(img);
                dateTimePicker1.Value = dob;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string Sid = comboBox1.Text;

            string qr = "delete from Student where Stu_Id='" + Sid + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted successfully");
            comboBox1.Text = "---Select ID---";
            textBox1.Clear();
            comboBox1.Items.Clear();
            dateTimePicker1.Value = Convert.ToDateTime("1/1/2000");
            con.Close();

            //

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            con.Close();
        }

        private void DeleteStu_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
