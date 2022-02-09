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
    public partial class ProductListWindow : Form
    {
        DateTime LastActionTime;
        public PaymentWindow Payment = null;
        public BarcodeReadingWindow BarcodeReading = null;
        public LoginToSettingsWindow LoginToSettings = null;
        public InformationWindow InformationWin = null;

        public bool IsCheckActivity = true;
        public List<string> ListOfProducts = new List<string>(); //Массив со списком продуктов
        public bool IsAgeConfirmed = false;

        public ProductListWindow()
        {
            InitializeComponent();
            KeyPreview = true;
            CurrentTime.Text = DateTime.Now.ToString("dd MMMM, HH:mm"); //Инициализация текущего времени
            LastActionTime = DateTime.Now;
            ClockTimer.Start();
        }

        void CloseChildren()
        {
            if (Payment != null)
            {
                Payment.CloseChildren();

                Payment.Close();
            }
            else if (BarcodeReading != null)
            {
                BarcodeReading.CloseChildren();

                BarcodeReading.Close();
            }
            else if (LoginToSettings != null)
            {
                LoginToSettings.CloseChildren();

                LoginToSettings.Close();
            }
            else if (InformationWin != null)
            {
                InformationWin.Close();
            }
        }

        public void UpdateLastActionTime()
        {
            LastActionTime = DateTime.Now;
        }

        private void PayMoney_Click(object sender, EventArgs e)
        {
            UpdateLastActionTime();
            if (ListOfProducts.Count == 0) return;
            PaymentWindow window = new PaymentWindow(this);
            Payment = window;
            window.ShowDialog();
            Payment = null;
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            UpdateLastActionTime();
            BarcodeReadingWindow window = new BarcodeReadingWindow(this);
            BarcodeReading = window;
            window.ShowDialog();
            BarcodeReading = null;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            UpdateLastActionTime();
            LoginToSettingsWindow window = new LoginToSettingsWindow(this);
            LoginToSettings = window;
            window.ShowDialog();
            LoginToSettings = null;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToString("dd MMMM, HH:mm"); //Обновление текущего времени

            long TimeFromLastAction = DateTime.Now.Ticks - LastActionTime.Ticks;
            DateTime Time = new DateTime(TimeFromLastAction);
            if (Time.Minute >= 1)
            {
                if (IsCheckActivity)
                {
                    CloseChildren();

                    if (ListOfProducts.Count > 0)
                    {
                        IsCheckActivity = false;
                        AssistantWaitingWindow window = new AssistantWaitingWindow(false, this);
                        window.ShowDialog();
                        UpdateLastActionTime();
                        IsCheckActivity = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void ProductListWindow_Load(object sender, EventArgs e)
        {
            TableWithListOfProduct.RowStyles[0].Height = 10;
        }

        private void CallAdmin_Click(object sender, EventArgs e)
        {
            IsCheckActivity = false;
            AssistantWaitingWindow window = new AssistantWaitingWindow(false, this);
            window.ShowDialog();
            UpdateLastActionTime();
            IsCheckActivity = true;
        }

        private void ProductListWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                Keys PressedKeys = e.KeyData;
                PressedKeys &= ~Keys.Control;
                if(PressedKeys == Keys.S)
                {
                    SettingsWindow window = new SettingsWindow();
                    window.ShowDialog();
                    this.Close();
                }
                if (PressedKeys == Keys.A)
                {
                    string Text = "";
                    Random Randomize = new Random();
                    switch (Randomize.Next(11))
                    {
                        case 0: Text = "3014260801786"; break;
                        case 1: Text = "3245990001218"; break;
                        case 2: Text = "4820000944038"; break;
                        case 3: Text = "4820017000253"; break;
                        case 4: Text = "4820183771506"; break;
                        case 5: Text = "4820202460145"; break;
                        case 6: Text = "4823013404018"; break;
                        case 7: Text = "4823061320261"; break;
                        case 8: Text = "4823063109918"; break;
                        case 9: Text = "4823077613258"; break;
                        case 10: Text = "5000159376655"; break;
                    }
                    BarcodeReadingWindow window = new BarcodeReadingWindow(this, Text);
                }
                if (PressedKeys == Keys.Q)
                {
                    this.Close();
                }
            }
        }

        private void Information_Click(object sender, EventArgs e)
        {
            UpdateLastActionTime();
            InformationWindow window = new InformationWindow();
            InformationWin = window;
            window.ShowDialog();
            InformationWin = null;
            UpdateLastActionTime();
        }
    }
}
