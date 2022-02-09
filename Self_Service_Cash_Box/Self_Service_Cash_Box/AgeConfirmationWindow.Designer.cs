namespace Self_Service_Cash_Box
{
    partial class AgeConfirmationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeConfirmationWindow));
            this.InfoAgeConfirmation = new System.Windows.Forms.Label();
            this.Refuse = new System.Windows.Forms.Button();
            this.Allow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoAgeConfirmation
            // 
            this.InfoAgeConfirmation.AutoSize = true;
            this.InfoAgeConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.InfoAgeConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAgeConfirmation.Location = new System.Drawing.Point(63, 26);
            this.InfoAgeConfirmation.Name = "InfoAgeConfirmation";
            this.InfoAgeConfirmation.Size = new System.Drawing.Size(449, 66);
            this.InfoAgeConfirmation.TabIndex = 0;
            this.InfoAgeConfirmation.Text = "Разрешить продажу товара\r\nс возрастными ограничениями?";
            this.InfoAgeConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Refuse
            // 
            this.Refuse.BackColor = System.Drawing.Color.Transparent;
            this.Refuse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refuse.BackgroundImage")));
            this.Refuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refuse.FlatAppearance.BorderSize = 0;
            this.Refuse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Refuse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Refuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refuse.Location = new System.Drawing.Point(30, 134);
            this.Refuse.Name = "Refuse";
            this.Refuse.Size = new System.Drawing.Size(200, 50);
            this.Refuse.TabIndex = 1;
            this.Refuse.Text = "Запретить";
            this.Refuse.UseVisualStyleBackColor = false;
            this.Refuse.Click += new System.EventHandler(this.Refuse_Click);
            // 
            // Allow
            // 
            this.Allow.BackColor = System.Drawing.Color.Transparent;
            this.Allow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Allow.BackgroundImage")));
            this.Allow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Allow.FlatAppearance.BorderSize = 0;
            this.Allow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Allow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Allow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Allow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Allow.Location = new System.Drawing.Point(345, 134);
            this.Allow.Name = "Allow";
            this.Allow.Size = new System.Drawing.Size(200, 50);
            this.Allow.TabIndex = 2;
            this.Allow.Text = "Разрешить";
            this.Allow.UseVisualStyleBackColor = false;
            this.Allow.Click += new System.EventHandler(this.Allow_Click);
            // 
            // AgeConfirmationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 211);
            this.ControlBox = false;
            this.Controls.Add(this.Allow);
            this.Controls.Add(this.Refuse);
            this.Controls.Add(this.InfoAgeConfirmation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgeConfirmationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgeConfirmationWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoAgeConfirmation;
        private System.Windows.Forms.Button Refuse;
        private System.Windows.Forms.Button Allow;
    }
}