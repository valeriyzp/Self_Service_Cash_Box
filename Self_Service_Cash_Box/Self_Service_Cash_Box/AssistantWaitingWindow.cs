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
    public partial class AssistantWaitingWindow : Form
    {
        bool AgeRestrictions;
        public ProductListWindow ProductList;

        public AssistantWaitingWindow(bool IsAgeRestrictions, ProductListWindow Parent)
        {
            InitializeComponent();
            AgeRestrictions = IsAgeRestrictions;
            ProductList = Parent;
            KeyPreview = true;
        }

        private void AssistantWaitingWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                Keys PressedKeys = e.KeyData;
                PressedKeys &= ~Keys.Control;
                if (PressedKeys == Keys.Q)
                {
                    if(AgeRestrictions)
                    {
                        AgeConfirmationWindow window = new AgeConfirmationWindow(this);
                        window.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
