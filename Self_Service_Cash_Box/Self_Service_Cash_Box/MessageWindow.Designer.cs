namespace Self_Service_Cash_Box
{
    partial class MessageWindow
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
            this.TableForMessage = new System.Windows.Forms.TableLayoutPanel();
            this.Message = new System.Windows.Forms.Label();
            this.TableForMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableForMessage
            // 
            this.TableForMessage.BackColor = System.Drawing.Color.Transparent;
            this.TableForMessage.ColumnCount = 1;
            this.TableForMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForMessage.Controls.Add(this.Message, 0, 0);
            this.TableForMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableForMessage.Location = new System.Drawing.Point(0, 0);
            this.TableForMessage.Name = "TableForMessage";
            this.TableForMessage.RowCount = 1;
            this.TableForMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForMessage.Size = new System.Drawing.Size(284, 161);
            this.TableForMessage.TabIndex = 0;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(3, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(278, 161);
            this.Message.TabIndex = 0;
            this.Message.Text = "Такого штрихкода не существует";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Message.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Message_MouseClick);
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.TableForMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TableForMessage.ResumeLayout(false);
            this.TableForMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableForMessage;
        private System.Windows.Forms.Label Message;
    }
}