
namespace Hostel_Tracking
{
    partial class frmCustomers
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.mskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 462);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1018, 220);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tc No";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Room";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Check-In Date";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Check-Out Date";
            this.columnHeader11.Width = 120;
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowCustomers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnShowCustomers.Location = new System.Drawing.Point(756, 217);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(254, 54);
            this.btnShowCustomers.TabIndex = 28;
            this.btnShowCustomers.Text = "Show Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(756, 277);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(254, 54);
            this.btnUpdateCustomer.TabIndex = 28;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDeleteCustomers.Location = new System.Drawing.Point(756, 337);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(254, 54);
            this.btnDeleteCustomers.TabIndex = 28;
            this.btnDeleteCustomers.Text = "Delete Customers";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSearch.Location = new System.Drawing.Point(905, 404);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 39);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(679, 404);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 39);
            this.txtSearch.TabIndex = 29;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.Info;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(148, 108);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(331, 28);
            this.cmbGender.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(53, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 28);
            this.label10.TabIndex = 50;
            this.label10.Text = "Gender :";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(679, 168);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(331, 34);
            this.txtPrice.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(603, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 28);
            this.label9.TabIndex = 48;
            this.label9.Text = "Price :";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCheckOut.Location = new System.Drawing.Point(679, 121);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(331, 32);
            this.dtpCheckOut.TabIndex = 47;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCheckIn.Location = new System.Drawing.Point(679, 72);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(331, 32);
            this.dtpCheckIn.TabIndex = 46;
            // 
            // mskTxtPhone
            // 
            this.mskTxtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.mskTxtPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtPhone.Location = new System.Drawing.Point(148, 151);
            this.mskTxtPhone.Mask = "(999) 000-0000";
            this.mskTxtPhone.Name = "mskTxtPhone";
            this.mskTxtPhone.Size = new System.Drawing.Size(331, 32);
            this.mskTxtPhone.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(148, 18);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 34);
            this.txtName.TabIndex = 43;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRoomNo.Location = new System.Drawing.Point(679, 18);
            this.txtRoomNo.Multiline = true;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(331, 34);
            this.txtRoomNo.TabIndex = 42;
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTcNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTcNo.Location = new System.Drawing.Point(148, 243);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Multiline = true;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(331, 34);
            this.txtTcNo.TabIndex = 41;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(148, 196);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(331, 34);
            this.txtMail.TabIndex = 44;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Info;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(148, 64);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(331, 34);
            this.txtSurname.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(501, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "Check-Out Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(518, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 28);
            this.label7.TabIndex = 38;
            this.label7.Text = "Check-In Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(512, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "Room Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(53, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "T.C. No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(77, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(60, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name :";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1043, 694);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.mskTxtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.Text = "Customer Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.MaskedTextBox mskTxtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}