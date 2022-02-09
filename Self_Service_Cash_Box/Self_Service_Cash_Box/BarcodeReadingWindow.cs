using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Self_Service_Cash_Box
{
    public partial class BarcodeReadingWindow : Form
    {
        ProductListWindow ProductList; //Окно со списком продуктов, в которое добавляем продукт по штрихкоду
        MessageWindow Message = null;
        bool IsBar = false; //Наличие вертикального штриха указывающего на позицию ввода штрихкода

        MySqlConnection ConnectionToMySql = new MySqlConnection("server=localhost;user=root;database=self_service_cash_box;password=0000");

        public BarcodeReadingWindow(ProductListWindow Parent)
        {
            InitializeComponent();
            KeyPreview = true;
            ProductList = Parent;
            RefreshBarTimer.Start(); //Запустили таймер для обработки мигающей черты ввода штрихкода
        }

        public BarcodeReadingWindow(ProductListWindow Parent, string Code)
        {
            InitializeComponent();
            ProductList = Parent;
            Barcode.Text = Code;
            RefreshBarTimer.Start(); //Запустили таймер для обработки мигающей черты ввода штрихкода
            AcceptBarcode_Click(null, null);
            this.Close();
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
            this.Close(); //Закрытие формы ввода штрихкода при отмене ввода
        }

        void AddProductToList(string Code)
        {
            ProductList.ListOfProducts.Add(Code);

            ProductList.TableWithListOfProduct.RowCount++;
            ProductList.TableWithListOfProduct.RowCount++;

            ProductList.TableWithListOfProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ProductList.TableWithListOfProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F)); //Добавили в таблицу строку с продуктом и строку отступ

            ButtonForTableClass DeleteButton = new ButtonForTableClass(ProductList.TableWithListOfProduct.RowCount - 2, 9);
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.BackgroundImage = Properties.Resources.Delete;
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            DeleteButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            DeleteButton.Click += new EventHandler(DeleteButton_Click); //Создали кнопку удаления строки и добавили обработку нажатия
            ProductList.TableWithListOfProduct.Controls.Add(DeleteButton, DeleteButton.Column, DeleteButton.Row); //Вставили кнопку удалить в таблицу

            Label NameOfProduct = new Label();
            NameOfProduct.Dock = DockStyle.Fill;
            NameOfProduct.TextAlign = ContentAlignment.MiddleLeft;
            NameOfProduct.Text = GetNameCode(Code);
            NameOfProduct.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular);
            ProductList.TableWithListOfProduct.Controls.Add(NameOfProduct, 1, DeleteButton.Row);//Вставили название товара

            Label Price = new Label();
            Price.Dock = DockStyle.Fill;
            Price.TextAlign = ContentAlignment.MiddleCenter;
            Price.Text = GetPriceCode(Code);
            Price.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular);
            ProductList.TableWithListOfProduct.Controls.Add(Price, 2, DeleteButton.Row);//Вставили цену товара

            Label Count = new Label();
            Count.Dock = DockStyle.Fill;
            Count.TextAlign = ContentAlignment.MiddleCenter;
            Count.Text = GetCountCode(Code);
            Count.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular);
            ProductList.TableWithListOfProduct.Controls.Add(Count, 5, DeleteButton.Row);//Вставили количество товара

            string ProductSum = (Convert.ToDecimal(Count.Text) * Convert.ToDecimal(Price.Text)).ToString("0.00");

            Label Sum = new Label();
            Sum.Dock = DockStyle.Fill;
            Sum.TextAlign = ContentAlignment.MiddleCenter;
            Sum.Text = ProductSum;
            Sum.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular);
            ProductList.TableWithListOfProduct.Controls.Add(Sum, 8, DeleteButton.Row);//Вставили сумму товара

            ButtonForTableClass AddButton = new ButtonForTableClass(ProductList.TableWithListOfProduct.RowCount - 2, 6);
            AddButton.Dock = DockStyle.Fill;
            AddButton.BackColor = Color.Transparent;
            AddButton.BackgroundImage = Properties.Resources.Add;
            AddButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            AddButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            AddButton.Click += new EventHandler(AddButton_Click);
            ProductList.TableWithListOfProduct.Controls.Add(AddButton, 6, DeleteButton.Row); //Вставили кнопку добавить единицу в таблицу

            ButtonForTableClass MinusButton = new ButtonForTableClass(ProductList.TableWithListOfProduct.RowCount - 2, 4);
            MinusButton.Dock = DockStyle.Fill;
            MinusButton.BackColor = Color.Transparent;
            MinusButton.BackgroundImage = Properties.Resources.Minus;
            MinusButton.BackgroundImageLayout = ImageLayout.Stretch;
            MinusButton.FlatStyle = FlatStyle.Flat;
            MinusButton.FlatAppearance.BorderSize = 0;
            MinusButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            MinusButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            MinusButton.Click += new EventHandler(MinusButton_Click);
            ProductList.TableWithListOfProduct.Controls.Add(MinusButton, 4, DeleteButton.Row); //Вставили кнопку удалить единицу в таблицу

            UpdateSum();
        }

        void UpdateSum()
        {
            decimal Sum = 0;
            for(int i = 1; i < ProductList.TableWithListOfProduct.RowCount - 1; i += 2)
            {
                Sum += Convert.ToDecimal(ProductList.TableWithListOfProduct.GetControlFromPosition(8, i).Text);
            }
            ProductList.Sum.Text = Sum.ToString("0.00") + " грн.";
        }

        string GetNameCode(string Code)
        {
            ConnectionToMySql.Open();
            string Name;
            string Request = "SELECT nameproduct FROM barcodes WHERE barcode=" + Code;

            MySqlCommand Command = new MySqlCommand(Request, ConnectionToMySql);

            Name = Command.ExecuteScalar().ToString();

            ConnectionToMySql.Close();

            return Name;
        }

        string GetPriceCode(string Code)
        {
            ConnectionToMySql.Open();
            string Price;
            string Request = "SELECT price FROM barcodes WHERE barcode=" + Code;

            MySqlCommand Command = new MySqlCommand(Request, ConnectionToMySql);

            Price = Command.ExecuteScalar().ToString();

            ConnectionToMySql.Close();

            return Price;
        }

        string GetCountCode(string Code)
        {
            return 1.00.ToString("0.00");
        }

        bool IsCodeConfirmed(string Code)
        {
            if (Code == "") return false;
            ConnectionToMySql.Open();
            bool IsCode;
            string Request = "SELECT barcode FROM barcodes WHERE barcode=" + Code;

            MySqlCommand Command = new MySqlCommand(Request, ConnectionToMySql);

            if(Command.ExecuteScalar() != null)
            {
                IsCode = true;
            }
            else
            {
                IsCode = false;
            }
            ConnectionToMySql.Close();

            return IsCode;
        }

        bool IsAgeRestrictions(string Code)
        {
            ConnectionToMySql.Open();
            bool AgeRestrictions;
            string Request = "SELECT agerestrictions FROM barcodes WHERE barcode=" + Code;

            MySqlCommand Command = new MySqlCommand(Request, ConnectionToMySql);

            if (Command.ExecuteScalar().ToString() == "0") AgeRestrictions = false;
            else AgeRestrictions = true;

            ConnectionToMySql.Close();

            return AgeRestrictions;
        }

        private void AcceptBarcode_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            DeleteBarFromBarcode();
            string CodeOfProduct = Barcode.Text;

            if(IsCodeConfirmed(CodeOfProduct)) //Проверка на наличие штрихкода в базе
            {
                //Обновить массив с продуктами и обновить сумму!!!!!!!!!!!!!!
                bool IsAgeRestriction = IsAgeRestrictions(CodeOfProduct);
                if (IsAgeRestriction && !ProductList.IsAgeConfirmed)
                {
                    ProductList.IsCheckActivity = false;
                    AssistantWaitingWindow window = new AssistantWaitingWindow(true, this.ProductList);
                    window.ShowDialog();
                    ProductList.UpdateLastActionTime();
                    ProductList.IsCheckActivity = true;
                }
                if (!IsAgeRestriction || (IsAgeRestriction && ProductList.IsAgeConfirmed))
                {
                    AddProductToList(CodeOfProduct);
                }
                 //Добавили товар в список товаров
                this.Close();
            }
            else //Действия, если нет товара в базе
            {
                MessageWindow window = new MessageWindow("Несуществующий штрихкод");
                Message = window;
                window.ShowDialog();
                Message = null;
                ProductList.UpdateLastActionTime();
                Barcode.Text = "";
                IsBar = false;
            }
        }

        void AddButton_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            ButtonForTableClass AddButton = (ButtonForTableClass)sender;
            int RowForAdd = AddButton.Row;

            decimal Count = Convert.ToDecimal(ProductList.TableWithListOfProduct.GetControlFromPosition(5, RowForAdd).Text) + 1;
            ProductList.TableWithListOfProduct.GetControlFromPosition(5, RowForAdd).Text = Count.ToString("0.00");

            decimal Sum = Convert.ToDecimal(ProductList.TableWithListOfProduct.GetControlFromPosition(2, RowForAdd).Text) * Count;
            ProductList.TableWithListOfProduct.GetControlFromPosition(8, RowForAdd).Text = Sum.ToString("0.00");

            UpdateSum();
        }

        void MinusButton_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            ButtonForTableClass MinusButton = (ButtonForTableClass)sender;
            int RowForAdd = MinusButton.Row;

            decimal Count = Convert.ToDecimal(ProductList.TableWithListOfProduct.GetControlFromPosition(5, RowForAdd).Text) - 1;
            if(Count == 0)
            {
                DeleteButton_Click(ProductList.TableWithListOfProduct.GetControlFromPosition(9, RowForAdd), null);
                return;
            }
            ProductList.TableWithListOfProduct.GetControlFromPosition(5, RowForAdd).Text = Count.ToString("0.00");

            decimal Sum = Convert.ToDecimal(ProductList.TableWithListOfProduct.GetControlFromPosition(2, RowForAdd).Text) * Count;
            ProductList.TableWithListOfProduct.GetControlFromPosition(8, RowForAdd).Text = Sum.ToString("0.00");

            UpdateSum();
        }

        void DeleteButton_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();

            ButtonForTableClass DeleteButton = (ButtonForTableClass)sender;
            int RowForDelete = DeleteButton.Row; //Нашли строку в которой была нажата кнопка удаления 

            ProductList.ListOfProducts.RemoveAt((RowForDelete - 1) / 2);

            //Удалить из массива с продуктами!!!!!!!!!! и обновить сумму!!!!!!!!!!!!!

            for(int i = 0; i < ProductList.TableWithListOfProduct.ColumnCount; i++)
            {
                var element = ProductList.TableWithListOfProduct.GetControlFromPosition(i, RowForDelete);
                if (element != null) ProductList.TableWithListOfProduct.Controls.Remove(element);
            } //Удалили все елементы управления в строке, которую собираемся удалить

            //Перенесем все данные ниже удаляемой строки на 2 строки вверх, и удалим 2 последние строки (строка продукта + строка отступ)
            int NextProductRow = RowForDelete + 2; 

            while(NextProductRow < ProductList.TableWithListOfProduct.RowCount - 1)
            {
                for (int i = 0; i < ProductList.TableWithListOfProduct.ColumnCount; i++)
                {
                    if (i == 9 || i == 4 || i == 6) continue;
                    var element = ProductList.TableWithListOfProduct.GetControlFromPosition(i, NextProductRow);
                    if(element != null)
                    {
                        ProductList.TableWithListOfProduct.SetRow(element, NextProductRow - 2);
                    }
                }
                var DelButElement = (ButtonForTableClass)ProductList.TableWithListOfProduct.GetControlFromPosition(9, NextProductRow);
                var AddButElement = (ButtonForTableClass)ProductList.TableWithListOfProduct.GetControlFromPosition(4, NextProductRow);
                var MinusButElement = (ButtonForTableClass)ProductList.TableWithListOfProduct.GetControlFromPosition(6, NextProductRow);
                if (DelButElement != null) //Перенесли кнопку удаления каждой строки вверх к перенесенной строке и обновим значение текущей строки для кнопки удаления
                {
                    DelButElement.Row -= 2;
                    AddButElement.Row -= 2;
                    MinusButElement.Row -= 2;
                    ProductList.TableWithListOfProduct.SetRow(DelButElement, NextProductRow - 2);
                    ProductList.TableWithListOfProduct.SetRow(AddButElement, NextProductRow - 2);
                    ProductList.TableWithListOfProduct.SetRow(MinusButElement, NextProductRow - 2);
                }
                NextProductRow += 2;
            } //Перенесли все товары на позицию выше

            ProductList.TableWithListOfProduct.RowStyles.RemoveAt(ProductList.TableWithListOfProduct.RowCount - 1);
            ProductList.TableWithListOfProduct.RowCount--;
            ProductList.TableWithListOfProduct.RowStyles.RemoveAt(ProductList.TableWithListOfProduct.RowCount - 1);
            ProductList.TableWithListOfProduct.RowCount--; //Удалили 2 последние строки (товар + заполение) и удалили стили для них

            ProductList.TableWithListOfProduct.AutoScroll = false;
            ProductList.TableWithListOfProduct.AutoScroll = true; //Обновили размер ползунка для скроллинга

            UpdateSum();
        }

        void DeleteBarFromBarcode()
        {
            if (IsBar) //Если мигающая черта отображена, то убираем ее
            {
                Barcode.Text = Barcode.Text.Remove(Barcode.Text.Count() - 1);
                IsBar = false;
            }
        }

        private void RefreshBarTimer_Tick(object sender, EventArgs e)
        {
            if (Barcode.Text.Count() == 13 && !IsBar) return; //Если достигнута максимальная длина штрихкода (13 цифр), то мигающую черту не будем показывать
            if (IsBar) //Если мигающая черта отображена, то убираем ее
            {
                Barcode.Text = Barcode.Text.Remove(Barcode.Text.Count() - 1);
                IsBar = false;
            }
            else //Если мигающая черта отсутсвует, то добавляем ее
            {
                Barcode.Text = Barcode.Text + "|";
                IsBar = true;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            Barcode.Text = ""; //Очистили строку и указали что нет мигающего штриха
            IsBar = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            DeleteBarFromBarcode(); //Убрали мигающую черту
            if (Barcode.Text.Count() > 0) //Если в строка не пустая, то удаляем последнюю цифру
            {
                Barcode.Text = Barcode.Text.Remove(Barcode.Text.Count() - 1);
            }
        }

        void AddNumberToBarcode(string Number)
        {
            DeleteBarFromBarcode(); //Убрали мигающую черту
            if (Barcode.Text.Count() < 13) //Если у штрихкода не максимальная длина, то добавляем заданное число (строку) в него
            {
                Barcode.Text = Barcode.Text + Number;
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            ProductList.UpdateLastActionTime();
            AddNumberToBarcode("0");
        }

        private void BarcodeReadingWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                Keys PressedKeys = e.KeyData;
                PressedKeys &= ~Keys.Control;
                if (PressedKeys == Keys.A)
                {
                    Random Randomize = new Random();
                    switch (Randomize.Next(11))
                    {
                        case 0: Barcode.Text = "3014260801786"; break;
                        case 1: Barcode.Text = "3245990001218"; break;
                        case 2: Barcode.Text = "4820000944038"; break;
                        case 3: Barcode.Text = "4820017000253"; break;
                        case 4: Barcode.Text = "4820183771506"; break;
                        case 5: Barcode.Text = "4820202460145"; break;
                        case 6: Barcode.Text = "4823013404018"; break;
                        case 7: Barcode.Text = "4823061320261"; break;
                        case 8: Barcode.Text = "4823063109918"; break;
                        case 9: Barcode.Text = "4823077613258"; break;
                        case 10: Barcode.Text = "5000159376655"; break;
                    }
                    IsBar = false;
                    AcceptBarcode_Click(null, null);
                }
            }
        }
    }
}
