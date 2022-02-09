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
    public partial class SuccessfulPaymentWindow : Form
    {
        public PaymentWindow Payment;

        public SuccessfulPaymentWindow(PaymentWindow Parent)
        {
            InitializeComponent();
            Payment = Parent;
            TimerToCloseWindow.Start();
        }

        private void SuccessfulPaymentWindow_MouseClick(object sender, MouseEventArgs e)
        {
            this.Payment.ProductList.Close();
            this.Payment.Close();
            this.Close();
        }

        private void InfoSuccessfulPayment_MouseClick(object sender, MouseEventArgs e)
        {
            SuccessfulPaymentWindow_MouseClick(null, null);
        }

        private void InfoThankForPurchase_MouseClick(object sender, MouseEventArgs e)
        {
            SuccessfulPaymentWindow_MouseClick(null, null);
        }

        private void SuccessfulPaymentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Payment.ProductList.Close();
            this.Payment.Close();
        }

        private void TimerToCloseWindow_Tick(object sender, EventArgs e)
        {
            SuccessfulPaymentWindow_MouseClick(null, null);
        }
    }
}
