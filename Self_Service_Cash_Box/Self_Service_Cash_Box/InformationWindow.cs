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
    public partial class InformationWindow : Form
    {
        public InformationWindow()
        {
            InitializeComponent();
        }

        private void InformationWindow_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Information_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
