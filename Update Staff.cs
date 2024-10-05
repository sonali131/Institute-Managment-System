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
    public partial class Update_Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Update_Staff()
        {
            InitializeComponent();
        }
        string img;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string Sid = comboBox1.Text;
            string name = textBox1.Text;
            string Fname = textBox2.Text;
            string dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string Gen;
            if (radioButton1.Checked == true)
            {
                Gen = "M";
            }
            else
            {
                Gen = "F";
            }

            string Add = textBox3.Text;
            string cont = textBox4.Text;
            string adh = textBox5.Text;
            string subj = comboBox2.Text;
            string pay = textBox6.Text;
            string qr = "update staff set Staff_id='" + comboBox1.Text + "',Name='" + textBox1.Text + "',FName='" + textBox2.Text + "',DOB='" + dt + "',Gender='" + Gen + "',Address='" + textBox3.Text + "',Contact='" + textBox4.Text + "',Aadhar='" + textBox5.Text + "',Subj_Skill='" + comboBox2.Text + "',Pay_Skill='" + textBox6.Text + "',Image='" + img + "'where Staff_id='" + comboBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Record is Updated successfuly!!");
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Staff where Staff_Id='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string sname = rd[1].ToString();
                string fname = rd[2].ToString();
                DateTime dob = Convert.ToDateTime(rd[3].ToString());
                string gen = rd[4].ToString();
                string Add = rd[5].ToString();
                string cont = rd[6].ToString();
                string adh = rd[7].ToString();
                string subj = rd[8].ToString();
                string pay = rd[9].ToString();
                img = rd[10].ToString();
                textBox1.Text = sname;
                textBox2.Text = fname;
                dateTimePicker1.Value = dob;

                if (gen == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }



                textBox3.Text = Add;
                textBox4.Text = cont;
                textBox5.Text = adh;
                comboBox2.Text = subj;
                textBox6.Text = pay;
                pictureBox1.Image = new Bitmap(img);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Images files(*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                img = ofd.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Staff_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Staff", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add((ds.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
