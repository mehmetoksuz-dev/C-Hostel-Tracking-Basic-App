using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        public static Object[] user;
        public static string loggedUser;
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string passCheckQuery = "select Username,Password,UserId from ProgramUser where Username=@Username";
            try
            {
                List<dbConnection.cmdParameterType> loginParams = new List<dbConnection.cmdParameterType> {
                    new dbConnection.cmdParameterType("@Username",txtUserName.Text)
                };

                user = dbConnection.cmd_Select_DB(passCheckQuery, loginParams).Rows[0].ItemArray;
            }
            catch (Exception)
            {
                MessageBox.Show("User could not be found.");
                txtUserName.Clear();
                txtPassword.Clear();
                return;
            }

            string username = user[0].ToString();
            string pass = user[1].ToString();

            if (txtPassword.Text == pass)
            {
                loggedUser = txtUserName.Text;
                btnWeatherSit frmhome = new btnWeatherSit();
                frmhome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password!");
                txtUserName.Clear();
                txtPassword.Clear();
                return;
            }


        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            frmVisitorControl frmvstCnt = new frmVisitorControl();
            frmvstCnt.Show();
            this.Hide();
        }
    }
}
