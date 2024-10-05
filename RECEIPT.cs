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
    public partial class RECEIPT : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        string dt;
        public RECEIPT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiptPrint r = new ReceiptPrint();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                //string Duration = rd[2].ToString();
                comboBox3.Text = Cname;
            }
            con.Close();
        }

        private void RECEIPT_Load(object sender, EventArgs e)
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

            //

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Course", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add((ds1.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();
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
                string so = rd[2].ToString();
                // DateTime dob = Convert.ToDateTime(rd[3].ToString());
                //String dt = Convert.ToString(dateTimePicker1.Value);

                textBox1.Text = sname;
                textBox2.Text = so;
               // dateTimePicker1.Value = dob;

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String dt = Convert.ToString(dateTimePicker1.Value);
           


            string str = "insert into Receipt(Stu_Id,Student_Name,S_O_D_O,Admission_Fees,Date,Course_Id,Course_Name,Course_Fees,Paid,Due,Paid_to)values('" + comboBox1.Text +"','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dt +"','"+ comboBox2.Text + "','" + comboBox3.Text + "','" + textBox4.Text  +"','" + textBox5.Text  +"','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            con.Close();
        }
    }
}
