using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Calculator // класс для необходимых расчетах в калькульяторе
    {
        // Получение квадрата числа
        public double Square(double num)
        {
            return num * num;
        }

        // Получение корня числа
        public double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        // Получение суммы двух чисел 
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        // Получение уменожения двух чисел 
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Получение разницы двух чисел  
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        //Получение деления двух чисел
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        // Получение обратного числа
        public double Fraction(double num1)
        {
            return 1 / num1;
        }
    }
}
