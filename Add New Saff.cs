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
    public partial class Add_New_Saff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        String img;
        public Add_New_Saff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string gen;
            if (radioButton1.Checked == true)
            {
                gen = "M";

            }
            else
            {
                gen = "F";
            }
           
            string dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");


            string str = "insert into Staff(Staff_Id,Name,FName,DOB,Gender,Address,Contact,Aadhar,Subj_Skill,Pay_Skill,Image)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dt + "','" + gen + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "', '" + img + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
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
    }
}
