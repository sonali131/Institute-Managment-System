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
    public partial class Payment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            String dt = Convert.ToString(dateTimePicker1.Value);
           


            string str = "insert into Payment(Staff_Id,Date,Staff_Name,Monthly_Payment,Paid_to_Amount,Due_Amount)values('" + comboBox1.Text + "','" +  dt + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox4.Text+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

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
                textBox1.Text = sname;
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentReceipt pr = new PaymentReceipt();
            pr.Show();
        }
    }
}
