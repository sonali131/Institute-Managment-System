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
    public partial class DisplayStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public DisplayStu()
        {
            InitializeComponent();
        }

        private void DisplayStu_Load(object sender, EventArgs e)
        {
            con.Open();
            string qr = "Select * from Student";
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }
    }
}
