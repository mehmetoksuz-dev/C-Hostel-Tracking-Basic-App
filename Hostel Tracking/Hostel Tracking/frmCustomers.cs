using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hostel_Tracking
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        static string outMessage = "";
        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            string showCstQuery = "select * from AddCustomer";
            showCustomers(showCstQuery);
        }

        private void showCustomers(string showCstQuery) //db den müşterileri çektigimiz bölüm
        {
            listView1.Items.Clear();
            try
            {
                //string showCstQuery = "select * from AddCustomer";
                using (SqlConnection connection = new SqlConnection(dbConnection.srConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(showCstQuery, connection);
                    SqlDataReader dtRead = cmd.ExecuteReader();
                    while (dtRead.Read())
                    {
                        ListViewItem addItm = new ListViewItem();
                        addItm.Text = dtRead["CustomerId"].ToString();
                        addItm.SubItems.Add(dtRead["Name"].ToString());
                        addItm.SubItems.Add(dtRead["Surname"].ToString());
                        addItm.SubItems.Add(dtRead["Gender"].ToString());
                        addItm.SubItems.Add(dtRead["Phone"].ToString());
                        addItm.SubItems.Add(dtRead["Mail"].ToString());
                        addItm.SubItems.Add(dtRead["TcNo"].ToString());
                        addItm.SubItems.Add(dtRead["RoomNumber"].ToString());
                        addItm.SubItems.Add(dtRead["Price"].ToString());
                        addItm.SubItems.Add(dtRead["CheckInDate"].ToString());
                        addItm.SubItems.Add(dtRead["CheckOutDate"].ToString());

                        listView1.Items.Add(addItm);
                    }
                    connection.Close();
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e) //veriler forma aktarildi
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpCheckIn.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCheckOut.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            string deleteQuery = $"delete from AddCustomer where CustomerId='{id}'";
            dbConnection.update_database(deleteQuery, out outMessage);
            string showCstQuery = "select * from AddCustomer";
            showCustomers(showCstQuery);
            clearAreas();
        }

        void clearAreas()
        {
            txtName.Clear();
            txtSurname.Clear();
            cmbGender.Text = "";
            txtMail.Clear();
            txtTcNo.Clear();
            txtRoomNo.Clear();
            txtPrice.Clear();
            dtpCheckIn.ResetText(); // default value
            dtpCheckOut.ResetText();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string srUpdateQuery = "update AddCustomer set Name=@Name, Surname=@Surname, Gender=@Gender, " +
                "Phone=@Phone, Mail=@Mail, TcNo=@TcNo, RoomNumber=@RoomNumber, Price=@Price, " +
                "CheckInDate=@CheckInDate, CheckOutDate=@CheckOutDate where CustomerId=@CustomerId";
            List<dbConnection.cmdParameterType> resultParameters = new List<dbConnection.cmdParameterType>
            {
                    new dbConnection.cmdParameterType("@Name",txtName.Text),
                    new dbConnection.cmdParameterType("@Surname", txtSurname.Text),
                    new dbConnection.cmdParameterType("@Gender", cmbGender.Text),
                    new dbConnection.cmdParameterType("@Phone",mskTxtPhone.Text),
                    new dbConnection.cmdParameterType("@Mail",txtMail.Text),
                    new dbConnection.cmdParameterType("@TcNo",cmbGender.Text),
                    new dbConnection.cmdParameterType("@RoomNumber",txtRoomNo.Text),
                    new dbConnection.cmdParameterType("@Price",txtPrice.Text),
                    new dbConnection.cmdParameterType("@CheckInDate",dtpCheckIn.Value.ToString("yyyy-MM-dd")),
                    new dbConnection.cmdParameterType("@CheckOutDate",dtpCheckOut.Value.ToString("yyyy-MM-dd")),
                    new dbConnection.cmdParameterType("@CustomerId", id)
            };
            if (dbConnection.cmd_update_DB(srUpdateQuery, resultParameters) > 0)
            {
                MessageBox.Show("Informations are updated successfully.");
                string showCstQuery = "select * from AddCustomer";
                showCustomers(showCstQuery);
                clearAreas();
            }
            else
            {
                MessageBox.Show("Db Problem");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCstQuery = "select * from AddCustomer where Name like '%"+txtSearch.Text+"%'";
            showCustomers(searchCstQuery);
            txtSearch.Clear();
        }
    }
}
