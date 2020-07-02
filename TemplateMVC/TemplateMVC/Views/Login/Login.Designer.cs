namespace TemplateMVC.Views.Login
{
    partial class Login
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
            this.GBox_PanelLogin = new System.Windows.Forms.GroupBox();
            this.Btn_Forgot = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.GBox_PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_PanelLogin
            // 
            this.GBox_PanelLogin.Controls.Add(this.Btn_Forgot);
            this.GBox_PanelLogin.Controls.Add(this.Btn_Login);
            this.GBox_PanelLogin.Controls.Add(this.Txt_Password);
            this.GBox_PanelLogin.Controls.Add(this.Lbl_Password);
            this.GBox_PanelLogin.Controls.Add(this.Lbl_User);
            this.GBox_PanelLogin.Controls.Add(this.Txt_User);
            this.GBox_PanelLogin.Location = new System.Drawing.Point(12, 12);
            this.GBox_PanelLogin.Name = "GBox_PanelLogin";
            this.GBox_PanelLogin.Size = new System.Drawing.Size(258, 165);
            this.GBox_PanelLogin.TabIndex = 0;
            this.GBox_PanelLogin.TabStop = false;
            this.GBox_PanelLogin.Text = "Login";
            // 
            // Btn_Forgot
            // 
            this.Btn_Forgot.Location = new System.Drawing.Point(142, 129);
            this.Btn_Forgot.Name = "Btn_Forgot";
            this.Btn_Forgot.Size = new System.Drawing.Size(109, 23);
            this.Btn_Forgot.TabIndex = 6;
            this.Btn_Forgot.Text = "Forgot Password";
            this.Btn_Forgot.UseVisualStyleBackColor = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(6, 129);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(6, 94);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(245, 20);
            this.Txt_Password.TabIndex = 4;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(6, 78);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Password:";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(6, 29);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(90, 13);
            this.Lbl_User.TabIndex = 2;
            this.Lbl_User.Text = "UserName/Email:";
            // 
            // Txt_User
            // 
            this.Txt_User.Location = new System.Drawing.Point(6, 45);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(245, 20);
            this.Txt_User.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 188);
            this.Controls.Add(this.GBox_PanelLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.GBox_PanelLogin.ResumeLayout(false);
            this.GBox_PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_PanelLogin;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Button Btn_Forgot;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Password;
    }
}