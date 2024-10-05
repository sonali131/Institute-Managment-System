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
    public partial class Delete_Course : Form
    {

        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Delete_Course()
        {
            InitializeComponent();
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
                comboBox1.Text = Cname;    
                
            }
            con.Close();
        }

        private void Delete_Course_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string Cid = comboBox2.Text;

            string qr = "delete from Course where Course_Id='" + Cid + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted successfully");
            comboBox2.Text = "---Select ID---";     
            comboBox2.Items.Clear();
           
            con.Close();

            //

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
