
namespace Hostel_Tracking
{
    partial class frmIncomeExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpensePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSafeMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpensePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStaffSalaries = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProductsPrice = new System.Windows.Forms.Label();
            this.lblBills = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.btnCalculateIncome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Expense";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdatePrice);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(480, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 378);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Hostel Price";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.BackColor = System.Drawing.Color.Gray;
            this.btnUpdatePrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePrice.Location = new System.Drawing.Point(77, 175);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(146, 49);
            this.btnUpdatePrice.TabIndex = 28;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = false;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 123);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 32);
            this.txtPrice.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(16, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 56);
            this.label8.TabIndex = 24;
            this.label8.Text = "Please enter the new daily \r\n         price of Hostel ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbExpenseType);
            this.groupBox1.Controls.Add(this.btnAddExpense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtExpensePrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExpenseAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtExpenseName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 378);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Expense";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Items.AddRange(new object[] {
            "Food",
            "Bill",
            "Salary",
            "Others"});
            this.cmbExpenseType.Location = new System.Drawing.Point(193, 56);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(220, 33);
            this.cmbExpenseType.TabIndex = 25;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.Gray;
            this.btnAddExpense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExpense.Location = new System.Drawing.Point(267, 317);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(146, 49);
            this.btnAddExpense.TabIndex = 28;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Expense Type : ";
            // 
            // txtExpensePrice
            // 
            this.txtExpensePrice.Location = new System.Drawing.Point(193, 254);
            this.txtExpensePrice.Name = "txtExpensePrice";
            this.txtExpensePrice.Size = new System.Drawing.Size(220, 32);
            this.txtExpensePrice.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Expense Name : ";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(193, 192);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(220, 32);
            this.txtExpenseAmount.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(-1, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Expense Amount : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(19, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Expense Price : ";
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(193, 123);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(220, 32);
            this.txtExpenseName.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.tabPage2.Controls.Add(this.btnCalculateIncome);
            this.tabPage2.Controls.Add(this.lblTotalIncome);
            this.tabPage2.Controls.Add(this.lblBills);
            this.tabPage2.Controls.Add(this.lblProductsPrice);
            this.tabPage2.Controls.Add(this.lblStaffSalaries);
            this.tabPage2.Controls.Add(this.lblSafeMoney);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incomes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSafeMoney
            // 
            this.lblSafeMoney.AutoSize = true;
            this.lblSafeMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblSafeMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSafeMoney.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSafeMoney.Location = new System.Drawing.Point(310, 79);
            this.lblSafeMoney.Name = "lblSafeMoney";
            this.lblSafeMoney.Size = new System.Drawing.Size(36, 28);
            this.lblSafeMoney.TabIndex = 26;
            this.lblSafeMoney.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(41, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(700, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(235, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Bills :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price of Products Received :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(103, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Staff Salaries Paid :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(98, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Money In The Safe : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stocks - Expenses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 55;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseType,
            this.ExpenseName,
            this.ExpenseAmount,
            this.ExpensePrice});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(785, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExpenseType
            // 
            this.ExpenseType.HeaderText = "Expense Type";
            this.ExpenseType.MinimumWidth = 6;
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.ReadOnly = true;
            this.ExpenseType.Width = 200;
            // 
            // ExpenseName
            // 
            this.ExpenseName.HeaderText = "Expense Name";
            this.ExpenseName.MinimumWidth = 6;
            this.ExpenseName.Name = "ExpenseName";
            this.ExpenseName.ReadOnly = true;
            this.ExpenseName.Width = 250;
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.HeaderText = "Expense Amount";
            this.ExpenseAmount.MinimumWidth = 6;
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.ReadOnly = true;
            this.ExpenseAmount.Width = 150;
            // 
            // ExpensePrice
            // 
            this.ExpensePrice.HeaderText = "Expense Price";
            this.ExpensePrice.MinimumWidth = 6;
            this.ExpensePrice.Name = "ExpensePrice";
            this.ExpensePrice.ReadOnly = true;
            this.ExpensePrice.Width = 140;
            // 
            // lblStaffSalaries
            // 
            this.lblStaffSalaries.AutoSize = true;
            this.lblStaffSalaries.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffSalaries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaffSalaries.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStaffSalaries.Location = new System.Drawing.Point(310, 129);
            this.lblStaffSalaries.Name = "lblStaffSalaries";
            this.lblStaffSalaries.Size = new System.Drawing.Size(36, 28);
            this.lblStaffSalaries.TabIndex = 26;
            this.lblStaffSalaries.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(304, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 28);
            this.label13.TabIndex = 26;
            this.label13.Text = "00";
            // 
            // lblProductsPrice
            // 
            this.lblProductsPrice.AutoSize = true;
            this.lblProductsPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductsPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblProductsPrice.Location = new System.Drawing.Point(310, 177);
            this.lblProductsPrice.Name = "lblProductsPrice";
            this.lblProductsPrice.Size = new System.Drawing.Size(36, 28);
            this.lblProductsPrice.TabIndex = 26;
            this.lblProductsPrice.Text = "00";
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.BackColor = System.Drawing.Color.Transparent;
            this.lblBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBills.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBills.Location = new System.Drawing.Point(310, 225);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(36, 28);
            this.lblBills.TabIndex = 26;
            this.lblBills.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(154, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total Income :";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalIncome.Location = new System.Drawing.Point(310, 312);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(36, 28);
            this.lblTotalIncome.TabIndex = 26;
            this.lblTotalIncome.Text = "00";
            // 
            // btnCalculateIncome
            // 
            this.btnCalculateIncome.BackColor = System.Drawing.Color.Gray;
            this.btnCalculateIncome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateIncome.Location = new System.Drawing.Point(528, 225);
            this.btnCalculateIncome.Name = "btnCalculateIncome";
            this.btnCalculateIncome.Size = new System.Drawing.Size(213, 49);
            this.btnCalculateIncome.TabIndex = 29;
            this.btnCalculateIncome.Text = "Calculate Instantly";
            this.btnCalculateIncome.UseVisualStyleBackColor = false;
            this.btnCalculateIncome.Click += new System.EventHandler(this.btnCalculateIncome_Click);
            // 
            // frmIncomeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmIncomeExpense";
            this.Text = "Income - Expense";
            this.Load += new System.EventHandler(this.frmIncomeExpense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtExpensePrice;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpensePrice;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSafeMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculateIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label lblProductsPrice;
        private System.Windows.Forms.Label lblStaffSalaries;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}