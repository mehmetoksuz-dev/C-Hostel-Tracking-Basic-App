
namespace Hostel_Tracking
{
    partial class frmVisitor
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
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSendFeedBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnFeedBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFeedBack.ForeColor = System.Drawing.Color.Black;
            this.btnFeedBack.Location = new System.Drawing.Point(152, 37);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(160, 90);
            this.btnFeedBack.TabIndex = 2;
            this.btnFeedBack.Text = "Give Us Your Feedback";
            this.btnFeedBack.UseVisualStyleBackColor = false;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 213);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btnSendFeedBack
            // 
            this.btnSendFeedBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendFeedBack.Location = new System.Drawing.Point(179, 396);
            this.btnSendFeedBack.Name = "btnSendFeedBack";
            this.btnSendFeedBack.Size = new System.Drawing.Size(110, 42);
            this.btnSendFeedBack.TabIndex = 5;
            this.btnSendFeedBack.Text = "Send Us";
            this.btnSendFeedBack.UseVisualStyleBackColor = true;
            this.btnSendFeedBack.Visible = false;
            this.btnSendFeedBack.Click += new System.EventHandler(this.btnSendFeedBack_Click);
            // 
            // frmVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnSendFeedBack);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFeedBack);
            this.Name = "frmVisitor";
            this.Text = "Visitor FeedBack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVisitor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSendFeedBack;
    }
}