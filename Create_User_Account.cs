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
    public partial class Create_User_Account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Create_User_Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox3.Text;
            string pass = textBox5.Text;

            con.Open();
            if(textBox4.Text==textBox5.Text)
                { 
                    string cqr = "insert into Login values('"+uname+ "','" + pass + "')";
                    SqlCommand cmd = new SqlCommand(cqr, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User Account added successfully!!");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                    //con.Close();
                }
                else
                {
                    MessageBox.Show("Mismatch Password! Please re-enter your password");
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox4.Focus();
                con.Close();
                }
            //con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Logout_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Login", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uname = comboBox1.Text;
            string pass = textBox2.Text;

            con.Open();
            string qr = "select * from Login where User_Name='" + uname + "'and Password='" + pass + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mismatch Credintial!!!!!");
                textBox2.Clear();
                textBox2.Focus();
            }
            con.Close();

        }
    }
}
