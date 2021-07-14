using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            string OutMessage = "";

            DataTable dSet = dbConnection.return_data_set("select Name,Surname,RoomNumber from AddCustomer where RoomNumber is not null",
                out OutMessage).Tables[0];

            for (int i = 0; i < dSet.Rows.Count; i++) //dolu odaları aldık isim yazdırdık
            {
                if (btnRoom101.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom101.Text = dSet.Rows[i].ItemArray[0].ToString() +" "+ dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom101.BackColor = Color.Red;
                }
                else if (btnRoom102.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom102.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom102.BackColor = Color.Red;
                }
                else if (btnRoom103.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom103.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom103.BackColor = Color.Red;
                }
                else if (btnRoom104.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom104.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom104.BackColor = Color.Red;
                }
                else if (btnRoom105.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom105.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom105.BackColor = Color.Red;
                }
                else if (btnRoom106.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom106.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom106.BackColor = Color.Red;
                }
                else if (btnRoom107.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom107.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom107.BackColor = Color.Red;
                }
                else if (btnRoom108.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom108.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom108.BackColor = Color.Red;
                }
                else if (btnRoom109.Text == dSet.Rows[i].ItemArray[2].ToString())
                {
                    btnRoom109.Text = dSet.Rows[i].ItemArray[0].ToString() + " " + dSet.Rows[i].ItemArray[1].ToString();
                    btnRoom109.BackColor = Color.Red;
                }
            }
            
        }
    }
}
