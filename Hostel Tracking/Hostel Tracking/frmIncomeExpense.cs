using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hostel_Tracking
{
    public partial class frmIncomeExpense : Form
    {
        public frmIncomeExpense()
        {
            InitializeComponent();
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbExpenseType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select something from comboboxes.");
                return;
            }
            if (txtExpenseAmount.Text != "" || txtExpenseName.Text != "" || txtExpensePrice.Text != "")
            {
                string expenseQuery = "insert into Expenses(ExpenseType,ExpenseName,ExpenseAmount, ExpensePrice) values (@ExpenseType,@ExpenseName,@ExpenseAmount,@ExpensePrice)";
                List<dbConnection.cmdParameterType> expParam = new List<dbConnection.cmdParameterType> {
                    new dbConnection.cmdParameterType("@ExpenseType", cmbExpenseType.SelectedItem.ToString()),
                    new dbConnection.cmdParameterType("@ExpenseName", txtExpenseName.Text),
                    new dbConnection.cmdParameterType("@ExpenseAmount",txtExpenseAmount.Text),
                    new dbConnection.cmdParameterType("ExpensePrice", txtExpensePrice.Text)
                };

                if (dbConnection.cmd_update_DB(expenseQuery, expParam) > 0)
                {
                    MessageBox.Show("Expenses added to database successfully.");
                    getExpData();
                }
                else
                {
                    MessageBox.Show("There was happen a problem in db.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill all the areas.");
                return;
            }
        }

        private void frmIncomeExpense_Load(object sender, EventArgs e)
        {
            cmbExpenseType.SelectedIndex = 0;
            getExpData();
        }

        private void getExpData()
        {
            string srQuery = "select * from Expenses";
            DataTable ds = dbConnection.return_data_set(srQuery, out string Msg).Tables[0];
            if (ds.Rows.Count > 0)
            {
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(ds.Rows[i].ItemArray[0].ToString(),
                        ds.Rows[i].ItemArray[1].ToString(),
                        ds.Rows[i].ItemArray[2].ToString(),
                        ds.Rows[i].ItemArray[3].ToString());
                }
            }
            else
            {
                MessageBox.Show("No have data");
                return;
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                try
                {
                    string srUpdatePriceQry = "update Price set HostelPrice=@HostelPrice";
                    List<dbConnection.cmdParameterType> param = new List<dbConnection.cmdParameterType>
                    {
                        new dbConnection.cmdParameterType("@HostelPrice", txtPrice.Text)
                    };
                    if (dbConnection.cmd_update_DB(srUpdatePriceQry, param) > 0)
                    {
                        MessageBox.Show("Price of hostel updated successfully!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid value.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a price.");
            }
        }

        private void btnCalculateIncome_Click(object sender, EventArgs e)
        {
            var moneyInSafe = 0;
            string srMoneySafeQry = "select sum(Price) from AddCustomer";
            DataTable dsSumMoney = dbConnection.return_data_set(srMoneySafeQry, out string outSr).Tables[0];
            Object mnySafe = dsSumMoney.Rows[0].ItemArray[0];
            moneyInSafe = Convert.ToInt32(mnySafe);

            lblSafeMoney.Text = moneyInSafe.ToString(); //hosteldeki para

            var staffSalary = 0;

            string srStaffSalaryQry = "select sum(cast (ExpensePrice as int)) from Expenses where ExpenseType='Salary'"; //sutun varchar'di int'e cevirdik
            DataTable dsStaffSlry = dbConnection.return_data_set(srStaffSalaryQry, out string msg).Tables[0];
            Object stfSlry = dsStaffSlry.Rows[0].ItemArray[0];
            staffSalary = Convert.ToInt32(stfSlry);

            lblStaffSalaries.Text = staffSalary.ToString();


            var priceOfProducts = 0;
            //yemek ürünleri ve diğerlerini alınan ürünlerin fiyatına dahil ettik
            string priceProdQry = "select sum(cast (ExpensePrice as int)) from Expenses where ExpenseType='Food' or ExpenseType='Others'"; 
            DataTable dsPrcPrd = dbConnection.return_data_set(priceProdQry, out string msgOut).Tables[0];
            Object prcPrd = dsPrcPrd.Rows[0].ItemArray[0];
            priceOfProducts = Convert.ToInt32(prcPrd);

            lblProductsPrice.Text = priceOfProducts.ToString();


            var bills = 0; //faturalar
            string billsQry = "select sum(cast (ExpensePrice as int)) from Expenses where ExpenseType='Bill'";
            DataTable dsBills = dbConnection.return_data_set(billsQry, out string srOutb).Tables[0];
            Object objBill = dsBills.Rows[0].ItemArray[0];
            bills = Convert.ToInt32(objBill);

            lblBills.Text = bills.ToString();

            // Total Income 
            var totalExpenses = 0; 
            var totalIncome = 0;

            totalExpenses = staffSalary + priceOfProducts + bills; //all expenses

            totalIncome = moneyInSafe - totalExpenses; //money in safe - all expenses will be total income

            lblTotalIncome.Text = totalIncome.ToString();
        }
    }
}
