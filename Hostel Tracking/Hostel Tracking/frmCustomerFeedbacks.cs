using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmCustomerFeedbacks : Form
    {
        public frmCustomerFeedbacks()
        {
            InitializeComponent();
        }

        private void frmCustomerFeedbacks_Load(object sender, EventArgs e)
        {
            txtNameSurname.Enabled = false;
            richTxtFb.Enabled = false;

            showFeedBacks();
        }

        private void showFeedBacks()
        {
            try
            {
                string srFbQuery = "select * from FeedBack";
                DataTable dtFeedback = dbConnection.return_data_set(srFbQuery, out string msg).Tables[0];
                for (int i = 0; i < dtFeedback.Rows.Count; i++)
                {
                    ListViewItem addItm = new ListViewItem();
                    addItm.Text = dtFeedback.Rows[i].ItemArray[0].ToString(); //id
                    addItm.SubItems.Add(dtFeedback.Rows[i].ItemArray[2].ToString());//msg content
                    addItm.SubItems.Add(dtFeedback.Rows[i].ItemArray[1].ToString()); //name

                    listView1.Items.Add(addItm);
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            txtNameSurname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTxtFb.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
