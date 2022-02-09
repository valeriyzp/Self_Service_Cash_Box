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
    public partial class AgeConfirmationWindow : Form
    {
        AssistantWaitingWindow AssistantWaiting;

        public AgeConfirmationWindow(AssistantWaitingWindow Parent)
        {
            InitializeComponent();
            AssistantWaiting = Parent;
        }

        private void Allow_Click(object sender, EventArgs e)
        {
            AssistantWaiting.ProductList.IsAgeConfirmed = true;
            AssistantWaiting.Close();
            this.Close();
        }

        private void Refuse_Click(object sender, EventArgs e)
        {
            AssistantWaiting.Close();
            this.Close();
        }

        private void AgeConfirmationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            AssistantWaiting.Close();
        }
    }
}
