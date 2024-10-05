using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_MS
{
    public partial class IMS : Form
    {
        public IMS()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void displayToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void admissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void amoutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Update_Staff up = new Update_Staff();
            up.Show();
        }

        private void updateToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            UpdateStu us = new UpdateStu();
            us.Show();
        }

        private void updateToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Update_Staff up = new Update_Staff();
            up.Show();

        }

        private void notesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Saff ad = new Add_New_Saff();
            ad.Show();
        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Add_New_Saff ad = new Add_New_Saff();
            ad.Show();

        }

        private void displayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Display_Staff di = new Display_Staff();
            di.Show();

        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Delete_Staff de = new Delete_Staff();
            de.Show();
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Course ad = new Add_New_Course();
            ad.Show();
        }

        private void cSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Course uc = new Update_Course();
            uc.Show();
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display_Course ds = new Display_Course();
            ds.Show();

        }

        private void danceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Course dss = new Delete_Course();
            dss.Show();
        }

        private void displayToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Display_Staff ds = new Display_Staff();
            ds.Show();
        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Delete_Staff ds = new Delete_Staff();
            ds.Show();
        }

        private void admissionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
        }

        private void displayToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            DisplayStu dis = new DisplayStu();
            dis.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteStu des = new DeleteStu();
            des.Show();
        }

        private void admissionToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
        }

        private void admissionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
        }

        private void displayToolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            DisplayStu desp = new DisplayStu();
            desp.Show();
        }

        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }

        private void reciptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RECEIPT r = new RECEIPT();
            r.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();

        }

        private void reciptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RECEIPT r = new RECEIPT();
            r.Show();
        }

        private void staffToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchStaff ss = new SearchStaff();
            ss.Show();
        }

        private void paymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SearchPayment sp = new SearchPayment();
            sp.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCourse sc = new SearchCourse();
            sc.Show();
                
        }

        private void paymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RECEIPT r = new RECEIPT();
            r.Show();
        }

        private void displayAllPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAllPayment dl = new DisplayAllPayment();
            dl.Show();
        }

        private void displayAllRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAllReceipt dr = new DisplayAllReceipt();
            dr.Show();
        }

        private void IMS_Load(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void IMS_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void createNewUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_User_Account l = new Create_User_Account();
            l.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
