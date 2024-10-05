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
    public partial class Display_Course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SONALIMISHRA;Initial Catalog=Inst;Integrated Security=True");
        public Display_Course()
        {
            InitializeComponent();
        }

        private void Display_Course_Load(object sender, EventArgs e)
        {
            con.Open();
            string qr = "Select * from Course";
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }
    }
}
