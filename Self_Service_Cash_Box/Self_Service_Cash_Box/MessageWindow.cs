using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Cash_Box
{
    public partial class MessageWindow : Form
    {
        public MessageWindow(string MessageToDisplay)
        {
            InitializeComponent();
            Message.Text = MessageToDisplay;
        }

        private void Message_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
