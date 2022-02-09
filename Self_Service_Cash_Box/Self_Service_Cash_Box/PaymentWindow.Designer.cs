namespace Self_Service_Cash_Box
{
    partial class PaymentWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentWindow));
            this.TableWithSum = new System.Windows.Forms.TableLayoutPanel();
            this.InfoSum = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.InfoCardNumber = new System.Windows.Forms.Label();
            this.InfoPassword = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TableForCardNumber = new System.Windows.Forms.TableLayoutPanel();
            this.CardNumber = new System.Windows.Forms.Label();
            this.TableForPassword = new System.Windows.Forms.TableLayoutPanel();
            this.Password = new System.Windows.Forms.Label();
            this.RefreshBarTimer = new System.Windows.Forms.Timer(this.components);
            this.TableWithSum.SuspendLayout();
            this.TableForCardNumber.SuspendLayout();
            this.TableForPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableWithSum
            // 
            this.TableWithSum.BackColor = System.Drawing.Color.Transparent;
            this.TableWithSum.ColumnCount = 2;
            this.TableWithSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.TableWithSum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.TableWithSum.Controls.Add(this.InfoSum, 0, 0);
            this.TableWithSum.Controls.Add(this.Sum, 1, 0);
            this.TableWithSum.Location = new System.Drawing.Point(13, 13);
            this.TableWithSum.Name = "TableWithSum";
            this.TableWithSum.RowCount = 1;
            this.TableWithSum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableWithSum.Size = new System.Drawing.Size(419, 51);
            this.TableWithSum.TabIndex = 0;
            // 
            // InfoSum
            // 
            this.InfoSum.AutoSize = true;
            this.InfoSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoSum.Location = new System.Drawing.Point(23, 0);
            this.InfoSum.Name = "InfoSum";
            this.InfoSum.Size = new System.Drawing.Size(129, 51);
            this.InfoSum.TabIndex = 0;
            this.InfoSum.Text = "Сумма";
            this.InfoSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(158, 0);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(258, 51);
            this.Sum.TabIndex = 1;
            this.Sum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.Transparent;
            this.Two.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Two.BackgroundImage")));
            this.Two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Two.FlatAppearance.BorderSize = 0;
            this.Two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Two.Location = new System.Drawing.Point(316, 88);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 50);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.Transparent;
            this.One.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("One.BackgroundImage")));
            this.One.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.One.FlatAppearance.BorderSize = 0;
            this.One.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.One.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(245, 88);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 50);
            this.One.TabIndex = 3;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Transparent;
            this.Three.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Three.BackgroundImage")));
            this.Three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Three.FlatAppearance.BorderSize = 0;
            this.Three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Three.Location = new System.Drawing.Point(382, 88);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 50);
            this.Three.TabIndex = 4;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Transparent;
            this.Six.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Six.BackgroundImage")));
            this.Six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Six.FlatAppearance.BorderSize = 0;
            this.Six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Six.Location = new System.Drawing.Point(382, 153);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 50);
            this.Six.TabIndex = 5;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Transparent;
            this.Four.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Four.BackgroundImage")));
            this.Four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Four.FlatAppearance.BorderSize = 0;
            this.Four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.Location = new System.Drawing.Point(245, 153);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 50);
            this.Four.TabIndex = 6;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Transparent;
            this.Five.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Five.BackgroundImage")));
            this.Five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Five.FlatAppearance.BorderSize = 0;
            this.Five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.Location = new System.Drawing.Point(316, 153);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 50);
            this.Five.TabIndex = 7;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Transparent;
            this.Seven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Seven.BackgroundImage")));
            this.Seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Seven.FlatAppearance.BorderSize = 0;
            this.Seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seven.Location = new System.Drawing.Point(245, 218);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 50);
            this.Seven.TabIndex = 8;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Transparent;
            this.Eight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eight.BackgroundImage")));
            this.Eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eight.FlatAppearance.BorderSize = 0;
            this.Eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eight.Location = new System.Drawing.Point(316, 218);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 50);
            this.Eight.TabIndex = 9;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Transparent;
            this.Nine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nine.BackgroundImage")));
            this.Nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nine.FlatAppearance.BorderSize = 0;
            this.Nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nine.Location = new System.Drawing.Point(382, 218);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 50);
            this.Nine.TabIndex = 10;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Transparent;
            this.C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C.BackgroundImage")));
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C.FlatAppearance.BorderSize = 0;
            this.C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(245, 283);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 50);
            this.C.TabIndex = 11;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.Transparent;
            this.Zero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zero.BackgroundImage")));
            this.Zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero.Location = new System.Drawing.Point(316, 283);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(50, 50);
            this.Zero.TabIndex = 12;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(382, 283);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 50);
            this.Back.TabIndex = 13;
            this.Back.Text = "←";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InfoCardNumber
            // 
            this.InfoCardNumber.AutoSize = true;
            this.InfoCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.InfoCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoCardNumber.Location = new System.Drawing.Point(67, 100);
            this.InfoCardNumber.Name = "InfoCardNumber";
            this.InfoCardNumber.Size = new System.Drawing.Size(109, 20);
            this.InfoCardNumber.TabIndex = 16;
            this.InfoCardNumber.Text = "Номер карты";
            // 
            // InfoPassword
            // 
            this.InfoPassword.AutoSize = true;
            this.InfoPassword.BackColor = System.Drawing.Color.Transparent;
            this.InfoPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoPassword.Location = new System.Drawing.Point(91, 192);
            this.InfoPassword.Name = "InfoPassword";
            this.InfoPassword.Size = new System.Drawing.Size(67, 20);
            this.InfoPassword.TabIndex = 17;
            this.InfoPassword.Text = "Пароль";
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
            this.Accept.Location = new System.Drawing.Point(151, 278);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(50, 50);
            this.Accept.TabIndex = 18;
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
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
            this.Cancel.Location = new System.Drawing.Point(46, 278);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(50, 50);
            this.Cancel.TabIndex = 19;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TableForCardNumber
            // 
            this.TableForCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.TableForCardNumber.ColumnCount = 1;
            this.TableForCardNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForCardNumber.Controls.Add(this.CardNumber, 0, 0);
            this.TableForCardNumber.Location = new System.Drawing.Point(8, 123);
            this.TableForCardNumber.Name = "TableForCardNumber";
            this.TableForCardNumber.RowCount = 1;
            this.TableForCardNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForCardNumber.Size = new System.Drawing.Size(230, 40);
            this.TableForCardNumber.TabIndex = 20;
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.BackColor = System.Drawing.Color.White;
            this.CardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumber.Location = new System.Drawing.Point(3, 0);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(224, 40);
            this.CardNumber.TabIndex = 0;
            this.CardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CardNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardNumber_MouseClick);
            // 
            // TableForPassword
            // 
            this.TableForPassword.BackColor = System.Drawing.Color.Transparent;
            this.TableForPassword.ColumnCount = 1;
            this.TableForPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForPassword.Controls.Add(this.Password, 0, 0);
            this.TableForPassword.Location = new System.Drawing.Point(82, 215);
            this.TableForPassword.Name = "TableForPassword";
            this.TableForPassword.RowCount = 1;
            this.TableForPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForPassword.Size = new System.Drawing.Size(84, 40);
            this.TableForPassword.TabIndex = 21;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(3, 0);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Password.Size = new System.Drawing.Size(78, 40);
            this.Password.TabIndex = 0;
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_MouseClick);
            // 
            // RefreshBarTimer
            // 
            this.RefreshBarTimer.Interval = 750;
            this.RefreshBarTimer.Tick += new System.EventHandler(this.RefreshBarTimer_Tick);
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 346);
            this.ControlBox = false;
            this.Controls.Add(this.TableForPassword);
            this.Controls.Add(this.TableForCardNumber);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.InfoPassword);
            this.Controls.Add(this.InfoCardNumber);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.TableWithSum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaymentWindow_KeyDown);
            this.TableWithSum.ResumeLayout(false);
            this.TableWithSum.PerformLayout();
            this.TableForCardNumber.ResumeLayout(false);
            this.TableForCardNumber.PerformLayout();
            this.TableForPassword.ResumeLayout(false);
            this.TableForPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableWithSum;
        private System.Windows.Forms.Label InfoSum;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label InfoCardNumber;
        private System.Windows.Forms.Label InfoPassword;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel TableForCardNumber;
        private System.Windows.Forms.Label CardNumber;
        private System.Windows.Forms.TableLayoutPanel TableForPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Timer RefreshBarTimer;
    }
}