namespace Self_Service_Cash_Box
{
    partial class SuccessfulPaymentWindow
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
            this.InfoSuccessfulPayment = new System.Windows.Forms.Label();
            this.InfoThankForPurchase = new System.Windows.Forms.Label();
            this.TimerToCloseWindow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // InfoSuccessfulPayment
            // 
            this.InfoSuccessfulPayment.AutoSize = true;
            this.InfoSuccessfulPayment.BackColor = System.Drawing.Color.Transparent;
            this.InfoSuccessfulPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoSuccessfulPayment.Location = new System.Drawing.Point(13, 41);
            this.InfoSuccessfulPayment.Name = "InfoSuccessfulPayment";
            this.InfoSuccessfulPayment.Size = new System.Drawing.Size(549, 42);
            this.InfoSuccessfulPayment.TabIndex = 0;
            this.InfoSuccessfulPayment.Text = "Оплата произведена успешно";
            this.InfoSuccessfulPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoSuccessfulPayment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoSuccessfulPayment_MouseClick);
            // 
            // InfoThankForPurchase
            // 
            this.InfoThankForPurchase.AutoSize = true;
            this.InfoThankForPurchase.BackColor = System.Drawing.Color.Transparent;
            this.InfoThankForPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoThankForPurchase.Location = new System.Drawing.Point(141, 120);
            this.InfoThankForPurchase.Name = "InfoThankForPurchase";
            this.InfoThankForPurchase.Size = new System.Drawing.Size(308, 37);
            this.InfoThankForPurchase.TabIndex = 1;
            this.InfoThankForPurchase.Text = "Спасибо за покупку!";
            this.InfoThankForPurchase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoThankForPurchase_MouseClick);
            // 
            // TimerToCloseWindow
            // 
            this.TimerToCloseWindow.Interval = 10000;
            this.TimerToCloseWindow.Tick += new System.EventHandler(this.TimerToCloseWindow_Tick);
            // 
            // SuccessfulPaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 211);
            this.ControlBox = false;
            this.Controls.Add(this.InfoThankForPurchase);
            this.Controls.Add(this.InfoSuccessfulPayment);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuccessfulPaymentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuccessfulPaymentWindow_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SuccessfulPaymentWindow_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoSuccessfulPayment;
        private System.Windows.Forms.Label InfoThankForPurchase;
        private System.Windows.Forms.Timer TimerToCloseWindow;
    }
}