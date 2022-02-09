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
    public partial class LoginToSettingsWindow : Form
    {
        public ProductListWindow ProductList;
        public MessageWindow Message = null;

        public LoginToSettingsWindow(ProductListWindow Parent)
        {
            InitializeComponent();
            ProductList = Parent;
            KeyPreview = true;
        }

        public void CloseChildren()
        {
            if(Message != null)
            {
                Message.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            if (Login.Text == "admin" && Password.Text == "admin") //Проверка на правильность ввода логина и пароля
            {
                SettingsWindow window = new SettingsWindow(); //Открываем окно настроек
                window.ShowDialog();

                ProductList.Close(); //закрываем все остальные окна
                this.Close();
            }
            else //Если логин или пароль не правильные
            {
                MessageWindow window = new MessageWindow("Ошибка доступа");
                Message = window;
                window.ShowDialog();
                Message = null;
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
        }

        private void LoginToSettingsWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                Keys PressedKeys = e.KeyData;
                PressedKeys &= ~Keys.Control;
                if (PressedKeys == Keys.S)
                {
                    SettingsWindow window = new SettingsWindow();
                    window.ShowDialog();
                    ProductList.Close();
                    this.Close();
                }
            }
        }
    }
}
