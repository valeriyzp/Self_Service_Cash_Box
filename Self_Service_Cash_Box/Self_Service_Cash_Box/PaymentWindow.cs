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
    public partial class PaymentWindow : Form
    {
        public ProductListWindow ProductList;
        public MessageWindow Message = null;

        bool IsActiveCardNumber = true; //Проверка активности поля ввода номера карты
        bool IsBar = false; //Наличие отображенной мигающей черты
        private string PasswordForCard = ""; //Настоящий введенный пользователем пароль вместо ****

        public PaymentWindow(ProductListWindow Parent)
        {
            InitializeComponent();
            KeyPreview = true;
            ProductList = Parent;
            Sum.Text = ProductList.Sum.Text;
            RefreshBarTimer.Start();
        }

        public void CloseChildren()
        {
            if (Message != null)
            {
                Message.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            this.Close();
        }

        bool IsCardAccepted(string CardNumber, string Password)
        {
            if (CardNumber == "1111111111111111" && Password == "0000") return true;
            else return false;
        }

        bool IsEnoughMoney(string CardNumber, string Password)
        {
            Random rand = new Random();
            switch (rand.Next(5))
            {
                case 0:
                case 1:
                case 2:
                case 3: return true;
                case 4: return false;
            }
            return true;
        }

        bool IsPaymentAssepted(string CardNumber, string Password)
        {
            if (IsCardAccepted(CardNumber, Password))
            {
                if(IsEnoughMoney(CardNumber, Password)) //Если на карте достаточно денег
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            DeleteBar();
            string NumberOfCard = CardNumber.Text;
            
            if(IsPaymentAssepted(NumberOfCard, PasswordForCard)) //Проверка на корректность ввода данных карты и возможность снять деньги
            {
                //Перенесение данных о покупке в базу данных!!!




                SuccessfulPaymentWindow window = new SuccessfulPaymentWindow(this);
                window.ShowDialog();
            }
            else //Если данная карта не корректна
            {
                if (!IsCardAccepted(NumberOfCard, PasswordForCard))
                {
                    MessageWindow window = new MessageWindow("Неправильный номер карты или пароль");
                    Message = window;
                    window.ShowDialog();
                    ProductList.UpdateLastActionTime();
                    Message = null;
                }
                else
                {
                    MessageWindow window = new MessageWindow("Недостаточно денег на счету");
                    Message = window;
                    window.ShowDialog();
                    ProductList.UpdateLastActionTime();
                    Message = null;
                }

                CardNumber.Text = "";
                Password.Text = "";
                PasswordForCard = "";
                IsBar = false;
                IsActiveCardNumber = true;
            }
        }

        private void CardNumber_MouseClick(object sender, MouseEventArgs e)
        {
            ProductList.UpdateLastActionTime();

            if (IsBar && !IsActiveCardNumber) //Если есть мигающая черта и до нажатия фокус был на пароле, то убираем черту
            {
                Password.Text = Password.Text.Remove(Password.Text.Count() - 1);
                IsBar = false;
            }
            IsActiveCardNumber = true; //Делаем окно ввода номера карты активным
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            ProductList.UpdateLastActionTime();

            if (IsBar && IsActiveCardNumber) //Если есть мигающая черта и до нажатия фокус был не на пароле, то убираем черту
            {
                CardNumber.Text = CardNumber.Text.Remove(CardNumber.Text.Count() - 1);
                IsBar = false;
            }
            IsActiveCardNumber = false; //Делаем окно ввода пароля активным
        }

        void DeleteBar()
        {
            if (IsBar) //Если мигающая черта отображена, то убираем ее
            {
                if(IsActiveCardNumber) //Если активно окно ввода номера карты, то убираем мигающую черту от туда
                {
                    CardNumber.Text = CardNumber.Text.Remove(CardNumber.Text.Count() - 1); 
                }
                else //Иначе убираем мигающую черту из поля ввода пароля
                {
                    Password.Text = Password.Text.Remove(Password.Text.Count() - 1);
                }
                IsBar = false; //Показатель наличия отображенной мигающей черты не активен
            }
        }

        private void RefreshBarTimer_Tick(object sender, EventArgs e)
        {
            if(IsActiveCardNumber) //Если активно поле ввода номера карты, то уберем мигающую черту из него
            {
                if (CardNumber.Text.Count() == 16 && !IsBar) return; //Если достигнута максимальная длина номера карты (12 цифр), то мигающую черту не будем показывать
                if (IsBar) //Если мигающая черта отображена, то убираем ее
                {
                    CardNumber.Text = CardNumber.Text.Remove(CardNumber.Text.Count() - 1);
                    IsBar = false;
                }
                else //Если мигающая черта отсутсвует, то добавляем ее
                {
                    CardNumber.Text = CardNumber.Text + "|";
                    IsBar = true;
                }
            }
            else //Если активно поле ввода пароля убирем мигающую черту из него
            {
                if (Password.Text.Count() == 4 && !IsBar) return; //Если достигнута максимальная длина пинкода (4 цифры), то мигающую черту не будем показывать
                if (IsBar) //Если мигающая черта отображена, то убираем ее
                {
                    Password.Text = Password.Text.Remove(Password.Text.Count() - 1);
                    IsBar = false;
                }
                else //Если мигающая черта отсутсвует, то добавляем ее
                {
                    Password.Text = Password.Text + "|";
                    IsBar = true;
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            if (IsActiveCardNumber) //Если активно поле ввода номера карты, то опустошим его
            {
                CardNumber.Text = "";
                IsBar = false;
            }
            else //Если активно поле ввода пароля то опустошим его
            {
                Password.Text = "";
                PasswordForCard = ""; //Так как в поле пароля отображаем только ****, то изменим и значение реального пароля
                IsBar = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            DeleteBar(); //Убрали мигающую черту
            if (IsActiveCardNumber) //Если активно полее ввода номера карты, то удалим из него последнюю цифру, если она есть
            {
                if (CardNumber.Text.Count() > 0) //Если в строка не пустая, то удаляем последнюю цифру
                {
                    CardNumber.Text = CardNumber.Text.Remove(CardNumber.Text.Count() - 1);
                }
            }
            else //Если активно полее ввода пароля, то удалим из него последнюю цифру, если она есть
            {
                if (Password.Text.Count() > 0) //Если в строка не пустая, то удаляем последнюю цифру
                {
                    Password.Text = Password.Text.Remove(Password.Text.Count() - 1);
                    PasswordForCard = PasswordForCard.Remove(PasswordForCard.Count() - 1); //Так как в поле пароля отображаются **** то удалим и цифру из хранителя пароля
                }
            }
        }

        void AddNumberToActiveBox(string Number)
        {
            ProductList.UpdateLastActionTime();

            DeleteBar(); //Убрали мигающую черту
            if (IsActiveCardNumber)
            {
                if (CardNumber.Text.Count() < 16) //Если у номера карты не максимальная длина, то добавляем заданное число (строку) в него
                {
                    CardNumber.Text = CardNumber.Text + Number;
                }
            }
            else
            {
                if (Password.Text.Count() < 4) //Если у пароля не максимальная длина, то добавляем заданное число (строку) в него
                {
                    Password.Text = Password.Text + "*"; //Скрыли пароль, но показали, что добавился символ
                    PasswordForCard = PasswordForCard + Number; //Вписали значение в хранитель настоящего пароля
                }
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToActiveBox("0");
        }

        private void PaymentWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                Keys PressedKeys = e.KeyData;
                PressedKeys &= ~Keys.Control;
                if (PressedKeys == Keys.P)
                {
                    IsActiveCardNumber = true;
                    CardNumber.Text = "1111111111111111";
                    IsBar = false;
                    Password.Text = "****";
                    PasswordForCard = "0000";
                    Accept_Click(null, null);
                }
            }
        }
    }
}
