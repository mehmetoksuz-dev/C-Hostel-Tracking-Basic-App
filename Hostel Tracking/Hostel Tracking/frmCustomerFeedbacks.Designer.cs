
namespace Hostel_Tracking
{
    partial class frmCustomerFeedbacks
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
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtFb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.BackColor = System.Drawing.SystemColors.Info;
            this.txtNameSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameSurname.Location = new System.Drawing.Point(199, 104);
            this.txtNameSurname.Multiline = true;
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(404, 32);
            this.txtNameSurname.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 35);
            this.label3.TabIndex = 41;
            this.label3.Text = "FEEDBACKS (DOBULE CLICK ID AND SELECT)";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 461);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 146);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sender Name";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 325;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(87, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Feedback:";
            // 
            // richTxtFb
            // 
            this.richTxtFb.BackColor = System.Drawing.SystemColors.Info;
            this.richTxtFb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTxtFb.Location = new System.Drawing.Point(199, 158);
            this.richTxtFb.Name = "richTxtFb";
            this.richTxtFb.Size = new System.Drawing.Size(404, 261);
            this.richTxtFb.TabIndex = 46;
            this.richTxtFb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Incoming Feedbacks";
            // 
            // frmCustomerFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(635, 619);
            this.Controls.Add(this.richTxtFb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerFeedbacks";
            this.Text = "Customer Feedback";
            this.Load += new System.EventHandler(this.frmCustomerFeedbacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtFb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}