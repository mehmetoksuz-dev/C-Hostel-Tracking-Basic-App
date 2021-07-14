using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class btnWeatherSit : Form
    {
        public btnWeatherSit()
        {
            InitializeComponent();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer frmNewCst = new frmNewCustomer();
            frmNewCst.Show();
            //this.Hide();
        }

        private void btnCustomerOperations_Click(object sender, EventArgs e)
        {
            frmCustomers frmCust = new frmCustomers();            
            frmCust.Show();
            //this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblLoggedUser.Text = "Logged User : " + frmAdminLogin.loggedUser;
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); //current time
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            frmIncomeExpense stck = new frmIncomeExpense();
            stck.Show();
            stck.tabControl1.SelectTab(2);
        }

        private void btnIncomeExpense_Click(object sender, EventArgs e)
        {
            frmIncomeExpense stck = new frmIncomeExpense();
            stck.Show();
            stck.tabControl1.SelectTab(1);
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            frmUpdatePass updatepass = new frmUpdatePass();
            updatepass.Show();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            frmCustomerFeedbacks frmuserfb = new frmCustomerFeedbacks();
            frmuserfb.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
