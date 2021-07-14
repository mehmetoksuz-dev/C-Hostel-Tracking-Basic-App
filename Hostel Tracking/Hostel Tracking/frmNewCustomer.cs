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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
            DataSet getPrice = dbConnection.return_data_set("select HostelPrice from Price", out string msg);
            values =getPrice.Tables[0].Rows[0].ItemArray;
            pricePerDay = Convert.ToInt32(values[0]);
        }
        public static Object[] values;
        public static int pricePerDay;
        private void btnRoom101_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "101";
        }

        private void btnRoom102_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "102";
        }

        private void btnRoom103_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "103";
        }

        private void btnRoom104_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "104";
        }

        private void btnRoom105_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "105";
        }

        private void btnRoom106_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "106";
        }

        private void btnRoom107_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "107";
        }

        private void btnRoom108_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "108";
        }

        private void btnRoom109_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "109";
        }

        private void btnAvbRooms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green colored buttons show available rooms.");
        }

        private void btnFullRooms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red colored buttons show full rooms.");
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            int price; //oda fiyatı

            DateTime firstDate = Convert.ToDateTime(dtpCheckIn.Text);
            DateTime secondDate = Convert.ToDateTime(dtpCheckOut.Text);

            TimeSpan result = secondDate - firstDate; //aradaki zaman farkı

            label11.Text = result.TotalDays.ToString();

            price = Convert.ToInt32(label11.Text) * pricePerDay; //kalacağı gün * günlük fiyat
            txtPrice.Text = price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string addNewCustomerQuery = "insert into AddCustomer(Name,Surname,Gender,Phone,Mail,TcNo,RoomNumber,Price,CheckInDate,CheckOutDate) values" +
                    "(@Name,@Surname,@Gender,@Phone,@Mail,@TcNo,@RoomNumber,@Price,@CheckInDate,@CheckOutDate)";
                List<dbConnection.cmdParameterType> cstParam = new List<dbConnection.cmdParameterType>
                {
                    new dbConnection.cmdParameterType("@Name",txtName.Text),
                    new dbConnection.cmdParameterType("@Surname", txtSurname.Text),
                    new dbConnection.cmdParameterType("@Gender", cmbGender.Text),
                    new dbConnection.cmdParameterType("@Phone",mskTxtPhone.Text),
                    new dbConnection.cmdParameterType("@Mail",txtMail.Text),
                    new dbConnection.cmdParameterType("@TcNo",txtTcNo.Text),
                    new dbConnection.cmdParameterType("@RoomNumber",txtRoomNo.Text),
                    new dbConnection.cmdParameterType("@Price",txtPrice.Text),
                    new dbConnection.cmdParameterType("@CheckInDate",dtpCheckIn.Value.ToString("yyyy-MM-dd")),
                    new dbConnection.cmdParameterType("@CheckOutDate",dtpCheckOut.Value.ToString("yyyy-MM-dd"))
                };

                if (dbConnection.cmd_update_DB(addNewCustomerQuery, cstParam) > 0)
                {
                    roomCheck();
                    MessageBox.Show("Db'ye kaydedildi");
                    txtName.Clear();
                    txtSurname.Clear();
                    cmbGender.Text = "";
                    txtMail.Clear();
                    txtTcNo.Clear();
                    txtRoomNo.Clear();
                    txtPrice.Clear();
                    dtpCheckIn.ResetText();
                    dtpCheckOut.ResetText();
                }
                else
                {
                    MessageBox.Show("patladı");
                }
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            roomCheck();
        }

        private void roomCheck()
        {
            string OutMessage = "";

            DataTable dSet = dbConnection.return_data_set("select Name,Surname,RoomNumber from AddCustomer where RoomNumber is not null",
                out OutMessage).Tables[0];

            for (int i = 0; i < dSet.Rows.Count; i++) //dolu odaları aldık isim yazdırdık
            {
                if (btnRoom101.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom101.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom101.BackColor = Color.Red;
                    btnRoom101.Enabled = false;
                }
                else if (btnRoom102.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom102.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom102.BackColor = Color.Red;
                    btnRoom102.Enabled = false;
                }
                else if (btnRoom103.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom103.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom103.BackColor = Color.Red;
                    btnRoom103.Enabled = false;
                }
                else if (btnRoom104.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom104.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom104.BackColor = Color.Red;
                    btnRoom104.Enabled = false;
                }
                else if (btnRoom105.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom105.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom105.BackColor = Color.Red;
                    btnRoom105.Enabled = false;
                }
                else if (btnRoom106.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom106.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom106.BackColor = Color.Red;
                    btnRoom106.Enabled = false;
                }
                else if (btnRoom107.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom107.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom107.BackColor = Color.Red;
                    btnRoom107.Enabled = false;
                }
                else if (btnRoom108.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom108.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom108.BackColor = Color.Red;
                    btnRoom108.Enabled = false;
                }
                else if (btnRoom109.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom109.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom109.BackColor = Color.Red;
                    btnRoom109.Enabled = false;
                }
            }
        }
    }
}
