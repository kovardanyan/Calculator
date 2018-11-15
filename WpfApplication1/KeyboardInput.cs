using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class KeyboardInput //Класс для получение входных данных с клавиатуры 
    {
        public string Keyboard(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                return "0";
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                return "1";
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                return "2";
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                return "3";
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                return "4";
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                return "5";
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                return "6";
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                return "7";
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                return "8";
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                return "9";
            }
            else if (e.Key == Key.OemPeriod || e.Key == Key.OemComma || e.Key == Key.Decimal || e.Key == Key.Separator)
            {
                return ",";
            }
            else if (e.Key == Key.Back)
            {
                return "backspace"; 
            }
            else if (e.Key == Key.Enter)
            {
                return "enter";
            }
            else if (e.Key == Key.Add)
            {
                return "sum";
            }
            else if (e.Key == Key.Subtract)
            {
                return "subtract";
            }
            else if (e.Key == Key.Multiply)
            {
                return "multiply";
            }
            else if (e.Key == Key.Divide)
            {
                return "division";
            }
            else 
            {
                return "404";
            }
           
        }
    }
}
