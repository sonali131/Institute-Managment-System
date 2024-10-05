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
    public partial class Add_New_Course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Add_New_Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

           


            string str = "insert into Course(Course_Id,Course_Name,Duration)values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
