using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmVisitor : Form
    {
        public frmVisitor()
        {
            InitializeComponent();
        }

        private void frmVisitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text area activated for you. Please write your feedback on there and send us. Enjoy!");
            richTextBox1.Visible = true;
            btnSendFeedBack.Visible = true;
        }

        string authorname = frmVisitorControl.visitor[1].ToString() + " " + frmVisitorControl.visitor[2].ToString();
        private void btnSendFeedBack_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length < 500)
            {
                string srFbQuery = "insert into FeedBack(FeedBackContent, FeedBackAuthor) values (@FeedBackContent,@FeedBackAuthor)";
                List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType> {
                    new dbConnection.cmdParameterType("@FeedBackContent", richTextBox1.Text),
                    new dbConnection.cmdParameterType("@FeedBackAuthor",  authorname)
                };

                if (dbConnection.cmd_update_DB(srFbQuery, lstParam) > 0)
                {
                    MessageBox.Show("Your feedback has been sent to us successfully, thank you.");
                    richTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("There was a happen problem in db.");
                }
            }


            else
            {
                MessageBox.Show("Error! You can enter max 500 character.");
            }
        }
    }
}
