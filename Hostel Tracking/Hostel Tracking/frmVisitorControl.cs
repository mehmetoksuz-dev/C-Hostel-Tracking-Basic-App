using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmVisitorControl : Form
    {
        public frmVisitorControl()
        {
            InitializeComponent();
        }
        public static Object[] visitor;
        private void btnApprove_Click(object sender, EventArgs e)
        {
            string tcCheckQry = "select TcNo,Name,Surname from AddCustomer where TcNo=@TcNo";
            try
            {
                List<dbConnection.cmdParameterType> loginParams = new List<dbConnection.cmdParameterType> {
                    new dbConnection.cmdParameterType("@TcNo",txtVisitor.Text)
                };

                visitor = dbConnection.cmd_Select_DB(tcCheckQry, loginParams).Rows[0].ItemArray;
            }
            catch (Exception)
            {
                MessageBox.Show("Visitor can not approved please check your id number.");
                txtVisitor.Clear();
                return;
            }

            string tcNo = visitor[0].ToString();
            string visitorName = visitor[1].ToString() + " " + visitor[2].ToString();

            if (tcNo == txtVisitor.Text)
            {
                MessageBox.Show($"Hello {visitorName}, Welcome to Visitor Panel you approved with {tcNo}");
                frmVisitor frmVis = new frmVisitor();
                frmVis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Visitor can not approved please check your id number!");
                txtVisitor.Clear();
                return;
            }
        }
    }
}
