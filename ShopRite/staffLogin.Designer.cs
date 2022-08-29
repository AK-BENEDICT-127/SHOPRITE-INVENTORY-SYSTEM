namespace ShopRite
{
    partial class staffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffLogin));
            this.staffUsername = new System.Windows.Forms.Label();
            this.userNamestaff = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInbtn = new System.Windows.Forms.Button();
            this.resetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.BackColor = System.Drawing.Color.Transparent;
            this.staffUsername.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(390, 324);
            this.staffUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(177, 42);
            this.staffUsername.TabIndex = 0;
            this.staffUsername.Text = "Username:";
            // 
            // userNamestaff
            // 
            this.userNamestaff.BackColor = System.Drawing.Color.LightGray;
            this.userNamestaff.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamestaff.Location = new System.Drawing.Point(614, 317);
            this.userNamestaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNamestaff.Name = "userNamestaff";
            this.userNamestaff.Size = new System.Drawing.Size(288, 59);
            this.userNamestaff.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.LightGray;
            this.Password.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(614, 436);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(288, 59);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // logInbtn
            // 
            this.logInbtn.BackColor = System.Drawing.Color.LightGray;
            this.logInbtn.Font = new System.Drawing.Font("Calibri", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInbtn.Location = new System.Drawing.Point(549, 566);
            this.logInbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(155, 56);
            this.logInbtn.TabIndex = 4;
            this.logInbtn.Text = "Log In";
            this.logInbtn.UseVisualStyleBackColor = false;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = true;
            this.resetPassword.BackColor = System.Drawing.Color.Transparent;
            this.resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.Location = new System.Drawing.Point(859, 592);
            this.resetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(154, 20);
            this.resetPassword.TabIndex = 5;
            this.resetPassword.TabStop = true;
            this.resetPassword.Text = "Forgot Password?";
            this.resetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPassword_LinkClicked);
            // 
            // staffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1154, 655);
            this.Controls.Add(this.resetPassword);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNamestaff);
            this.Controls.Add(this.staffUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "staffLogin";
            this.Text = "staffLogin";
            this.Load += new System.EventHandler(this.staffLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox userNamestaff;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.LinkLabel resetPassword;
    }
}