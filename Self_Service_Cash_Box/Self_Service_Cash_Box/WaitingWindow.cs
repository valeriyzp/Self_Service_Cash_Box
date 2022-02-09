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
    public partial class WaitingWindow : Form
    {
        public WaitingWindow()
        {
            InitializeComponent();
        }

        private void WaitingWindow_MouseClick(object sender, MouseEventArgs e)
        {
            ProductListWindow window = new ProductListWindow();
            window.ShowDialog();
        }
    }
}
