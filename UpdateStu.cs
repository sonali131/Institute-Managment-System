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
    public partial class UpdateStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        string img;
        public UpdateStu()
        {
            InitializeComponent();
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
                string fname = rd[2].ToString();
                string mname = rd[3].ToString();
                DateTime dob = Convert.ToDateTime(rd[4].ToString());
                string gen = rd[5].ToString();
                string Religion = rd[6].ToString();
                string Add = rd[7].ToString();
                string city = rd[8].ToString();
                string sate = rd[9].ToString();
                string adh = rd[10].ToString();
                string pin = rd[11].ToString();
                string mobile = rd[12].ToString();
                string course = rd[13].ToString();
                img = rd[14].ToString();
                DateTime dd = Convert.ToDateTime(rd[15].ToString());

                textBox1.Text = sname;
                textBox2.Text = fname;
                textBox3.Text = mname;

                if (gen == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }


                dateTimePicker1.Value = dob;

                textBox4.Text = Religion;
                textBox5.Text = Add;
                comboBox2.Text = city;
                textBox6.Text = sate;
                textBox7.Text = adh;
                textBox8.Text = pin;
                textBox9.Text = mobile;
                textBox10.Text = course;
                pictureBox1.Image = new Bitmap(img);
                dateTimePicker2.Value = dd;
            }
            con.Close();
        }

        private void UpdateStu_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add((ds.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string StId = comboBox1.Text;
            string Sname = textBox1.Text;
            string Fname = textBox2.Text;
            string Mname = textBox3.Text;
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


            string Religion = textBox4.Text;
            string add = textBox5.Text;
            string city = comboBox2.Text;
            string state = textBox6.Text;
            string adh = textBox7.Text;
            string pin = textBox8.Text;
            string mobile = textBox9.Text;
            string course = textBox10.Text;
            string date = dateTimePicker2.Value.ToString("dd-MM-yyyy");
            //Convert.ToString(dateTimePicker2.Text);
            string qr = "update Student set Stu_Id='" + comboBox1.Text + "',Stu_Name='" + textBox1.Text + "',FName='" + textBox2.Text + "',MName='" + textBox3.Text + "',DOB='" + dt + "',Gender='" + Gen + "',Religion='" + textBox4.Text + "',Address='" + textBox5.Text + "',City='" + comboBox2.Text + "',State='" + textBox6.Text + "',Aadhar='" + textBox7.Text + "',Pin='" + textBox8.Text + "',Mobile='" + textBox9.Text + "',Course='" + textBox10.Text + "',Image='" + img +"',Date='"+date+ "'where Stu_Id='" + comboBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Record is Updated successfuly!!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
