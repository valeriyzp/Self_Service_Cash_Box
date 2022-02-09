namespace Self_Service_Cash_Box
{
    partial class InformationWindow
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
            this.Information = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.BackColor = System.Drawing.Color.Transparent;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(126, 93);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(348, 165);
            this.Information.TabIndex = 0;
            this.Information.Text = "Made by Valeriy Kozlov\r\n\r\nHuman Mashine Interface\r\n\r\n2018";
            this.Information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // InformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Information);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InformationWindow_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Information;
    }
}