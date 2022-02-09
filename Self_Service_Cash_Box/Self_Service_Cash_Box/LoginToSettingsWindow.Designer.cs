namespace Self_Service_Cash_Box
{
    partial class LoginToSettingsWindow
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.InfoPassword = new System.Windows.Forms.Label();
            this.InfoLogin = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BackgroundImage = global::Self_Service_Cash_Box.Properties.Resources.Delete;
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(50, 176);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(50, 50);
            this.Cancel.TabIndex = 25;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.Transparent;
            this.Accept.BackgroundImage = global::Self_Service_Cash_Box.Properties.Resources.Accept;
            this.Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Location = new System.Drawing.Point(194, 176);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(50, 50);
            this.Accept.TabIndex = 24;
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // InfoPassword
            // 
            this.InfoPassword.AutoSize = true;
            this.InfoPassword.BackColor = System.Drawing.Color.Transparent;
            this.InfoPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoPassword.Location = new System.Drawing.Point(112, 96);
            this.InfoPassword.Name = "InfoPassword";
            this.InfoPassword.Size = new System.Drawing.Size(67, 20);
            this.InfoPassword.TabIndex = 23;
            this.InfoPassword.Text = "Пароль";
            // 
            // InfoLogin
            // 
            this.InfoLogin.AutoSize = true;
            this.InfoLogin.BackColor = System.Drawing.Color.Transparent;
            this.InfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLogin.Location = new System.Drawing.Point(91, 14);
            this.InfoLogin.Name = "InfoLogin";
            this.InfoLogin.Size = new System.Drawing.Size(106, 20);
            this.InfoLogin.TabIndex = 22;
            this.InfoLogin.Text = "Имя доступа";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(12, 119);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(266, 40);
            this.Password.TabIndex = 21;
            this.Password.Text = "1234567890123456";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(12, 37);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(266, 40);
            this.Login.TabIndex = 20;
            this.Login.Text = "1234567890123456";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // LoginToSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 241);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.InfoPassword);
            this.Controls.Add(this.InfoLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginToSettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginToSettingsWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label InfoPassword;
        private System.Windows.Forms.Label InfoLogin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
    }
}