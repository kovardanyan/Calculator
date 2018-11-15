using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        double first_number; // Переменная для хранения первого чила
        double second_number; // Переменная для хранения второго чила
        string operation; // Переменная для определения выполненной операции
        Calculator clc = new Calculator(); // Создание экземпляра класс Calculator

        //Событие нажатия одной из кнопок с числами или запятой
        private void B_1_click(object sender, RoutedEventArgs e) 
        {
            Button button = sender as Button; // Создание экземпляра класса Button 
            Test(button.Content.ToString()); // Вызов метода Test 

        }

        // Событие нажатия кнопки смены знака
        private void Minus_Plus_click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text == "0" || txtBox.Text == "")
            {
                // Если значение 0 или отсуствует то ничего не происходит
            }
            else
            {
                char[] number = txtBox.Text.ToCharArray();
                if (number[0] == '-') // если первым символом строки являеться знак минуса то мы его просто убираем
                {
                    txtBox.Text = txtBox.Text.Trim(new char[] { '-' }); 
                }
                else // в обратном случае с начала строуи добавляем знак минуса
                {
                    txtBox.Text = '-' + txtBox.Text;
                }
            }
            
        }

        // Событие нажатия клавиши на клавиатуре
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardInput keyin = new KeyboardInput(); 
            string input_key = keyin.Keyboard(sender, e).ToString();
            int test1 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (input_key == i.ToString())
                {
                    Test(input_key);
                    test1++;
                }
            }
            switch (input_key)
            {
                case ".":
                    Test(input_key);
                    test1++;
                    break;
                case ",":
                    Test(input_key);
                    test1++;
                    break;
                case "sum":
                    Sum_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case "subtract":
                    Subtract_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case "division":
                    Division_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case "multiply":
                    Multiply_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case "enter":
                    Equal_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case "backspace":
                    Backspace_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                default:
                    break;
            }
        }

        // Метод для добавление в текстбокс введенного значения с клавиатуры или при нажатии кнопки с проверками 
        public void Test(string ka)
        {
            if (txtBox.Text == "0" && ka != "," || operation == "")
            {
                txtBox.Text = "";
            }
            int a = 0;
            if (ka == ",")
            {
                char[] number = txtBox.Text.ToCharArray();
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == ',')
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                    txtBox.Text = txtBox.Text + ka;
                }
            }
            else
            {
                txtBox.Text = txtBox.Text + ka;
            }
        }

        //Кнопка очистки последнего значения
        private void Clean_button_click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "0";
        }

        //Кнопка СУММИРОВАНИЯ
        private void Sum_botton_click(object sender, RoutedEventArgs e)
        {
            if (lbl.Content.ToString() != "" && lbl.Content.ToString() != "Error") // Прверка случая когда после суммирования не была нажата кнопка равно 
            {
                Equal_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)); // Вызов собития нажатия кнопки равно
            }

            first_number = Convert.ToDouble(txtBox.Text); // Первому числу присваивается значение строки в тексбоксе
            lbl.Content = txtBox.Text + " +"; // Показывает в label какое было последнее число и какая операция дальше будет выполнена
            txtBox.Text = "0";
            operation = "Sum"; 
        }

        
        //Кнопка РАЗНОСТИ
        // Все так как и в суммировании 
        private void Subtract_button_click(object sender, RoutedEventArgs e)
        {
            if (lbl.Content.ToString() != "" && lbl.Content.ToString() != "Error")
            {
                Equal_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            first_number = Convert.ToDouble(txtBox.Text);
            lbl.Content = txtBox.Text + " -";
            txtBox.Text = "0";
            operation = "Subtract";
        }

        //Кнопка УМНОЖЕНИЯ
        // Все так как и в суммировании 
        private void Multiply_button_click(object sender, RoutedEventArgs e)
        {
            if (lbl.Content.ToString() != "" && lbl.Content.ToString() != "Error")
            {
                Equal_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            first_number = Convert.ToDouble(txtBox.Text);
            lbl.Content = txtBox.Text + " *";
            txtBox.Text = "0";
            operation = "Multiply";
        }

        //Кнопка ДЕЛЕНИЯ
        // Все так как и в суммировании 
        private void Division_button_click(object sender, RoutedEventArgs e)
        {
            if (lbl.Content.ToString() != "" && lbl.Content.ToString() != "Error")
            {
                Equal_button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            first_number = Convert.ToDouble(txtBox.Text);
            lbl.Content = txtBox.Text + " /";
            txtBox.Text = "0";
            operation = "Division";
        }

        //Кнопка подсчета КВАДРАТА числа
        private void Square_button_click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(txtBox.Text); 
            txtBox.Text = clc.Square(first_number).ToString(); 
            lbl.Content = "sqr(" + first_number.ToString() + ")";
        }


        // Кнопка подсчета КОРНЯ
        private void Sqrt_button_click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(txtBox.Text);
            if (first_number >=0)
            {
                txtBox.Text = clc.Sqrt(first_number).ToString();
            }
            else
            {
                lbl.Content = "Error";
                txtBox.Text = "0";
            }
            lbl.Content = "sqrt(" + first_number.ToString() + ")";
        }

        //Кнопка подсчета обратного числа
        private void Fraction_button_click(object sender, RoutedEventArgs e)
        {

            first_number = Convert.ToDouble(txtBox.Text);
            if (first_number != 0)
            {
                txtBox.Text = clc.Fraction(first_number).ToString();
                lbl.Content = "reciproc(" + first_number.ToString() + ")";
            }
            else
            {
                lbl.Content = "Error";
                txtBox.Text = "0";
            }
        }
        //Нажатие кнопки РАВНО 
        private void equal_button_click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Sum":
                    second_number = Convert.ToDouble(txtBox.Text);
                    txtBox.Text = clc.Sum(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_sum";
                    break;
                case "Subtract":
                    second_number = Convert.ToDouble(txtBox.Text);
                    txtBox.Text = clc.Subtract(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_substract";
                    break;
                case "Multiply":
                    second_number = Convert.ToDouble(txtBox.Text);
                    txtBox.Text = clc.Multiply(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_multiply";
                    break;
                case "Division":
                    second_number = Convert.ToDouble(txtBox.Text);
                    if (second_number == 0)
                    {
                        lbl.Content = "Error";
                        txtBox.Text = "0";

                    }
                    else
                    {
                        txtBox.Text = clc.Division(first_number, second_number).ToString();
                        first_number = Convert.ToDouble(txtBox.Text);
                        operation = "Equal_division";
                    }
                    break;
                case "Equal_sum":
                    txtBox.Text = clc.Sum(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_sum";
                    break;
                case "Equal_substract":
                    txtBox.Text = clc.Subtract(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_substract";
                    break;
                case "Equal_multiply":
                    txtBox.Text = clc.Multiply(first_number, second_number).ToString();
                    first_number = Convert.ToDouble(txtBox.Text);
                    operation = "Equal_multiply";
                    break;
                case "Equal_division":
                    if (second_number == 0)
                    {
                        lbl.Content = "Error";
                        txtBox.Text = "0";

                    }
                    else
                    {
                        txtBox.Text = clc.Division(first_number, second_number).ToString();
                        first_number = Convert.ToDouble(txtBox.Text);
                        operation = "Equal_division";
                    }
                    break;
                default:
                    break;
            }
            if (lbl.Content.ToString() != "Error")
            {
                lbl.Content = "";
            }
        }


        // Приводит все в первоначальное состояние
        private void All_clean_button_click(object sender, RoutedEventArgs e)
        {
            first_number = 0;
            second_number = 0;
            txtBox.Text = "0";
            lbl.Content = "";
            operation = "";
        }

        // Удаления последнего символа из строки в текстбоксе
        private void Backspace_button_click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text.Length == 1)
            {
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
        }
    }
}
