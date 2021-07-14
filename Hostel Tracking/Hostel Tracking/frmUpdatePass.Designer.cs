
namespace Hostel_Tracking
{
    partial class frmUpdatePass
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
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePass.Location = new System.Drawing.Point(318, 258);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(197, 51);
            this.btnUpdatePass.TabIndex = 46;
            this.btnUpdatePass.Text = "Update Password";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(184, 98);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(331, 34);
            this.txtUserName.TabIndex = 45;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Info;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPass.Location = new System.Drawing.Point(184, 152);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(331, 34);
            this.txtNewPass.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(64, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(133, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 46);
            this.label4.TabIndex = 47;
            this.label4.Text = "Update Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(53, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pass Again :";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassAgain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassAgain.Location = new System.Drawing.Point(184, 203);
            this.txtPassAgain.Multiline = true;
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PasswordChar = '*';
            this.txtPassAgain.Size = new System.Drawing.Size(331, 34);
            this.txtPassAgain.TabIndex = 44;
            // 
            // frmUpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hostel_Tracking.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(537, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUpdatePass";
            this.Text = "Update Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassAgain;
    }
}