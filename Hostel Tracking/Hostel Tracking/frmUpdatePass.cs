using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmUpdatePass : Form
    {
        public frmUpdatePass()
        {
            InitializeComponent();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtPassAgain.Text)
            {
                MessageBox.Show("Both passwords entered must be the same!");
                return;
            }
            string updatePassQry = "update ProgramUser set Password=@Password where Username=@Username";
            List<dbConnection.cmdParameterType> lstprm = new List<dbConnection.cmdParameterType> { 
                new dbConnection.cmdParameterType("@Password",txtNewPass.Text),
                new dbConnection.cmdParameterType("@Username",txtUserName.Text)
            };
            if (dbConnection.cmd_update_DB(updatePassQry,lstprm) > 0)
            {
                MessageBox.Show("Your password updated successfully!");
                frmAdminLogin frmadmnlogn = new frmAdminLogin();
                frmadmnlogn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("There was happen problem in db");
                return;
            }
        }
    }
}
