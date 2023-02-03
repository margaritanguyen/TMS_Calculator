using System;

namespace TMS_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actionNumber;
            double value1;
            double value2;
            double resultValue;

        programStart:
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - деление");
            Console.WriteLine("4 - умножение");
            Console.WriteLine("5 - процент от числа");
            Console.WriteLine("6 - квадратный корень числа");
            Console.WriteLine("7 - выход из программы");

            actionNumber = Convert.ToInt32(Console.ReadLine());

            switch (actionNumber)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    resultValue = value1 + value2;
                    Console.WriteLine($"Результат: {value1} + {value2} = {resultValue} \n");
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    resultValue = value1 - value2;
                    Console.WriteLine($"Результат: {value1} - {value2} = {resultValue} \n");
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    resultValue = value1 / value2;
                    Console.WriteLine($"Результат: {value1} / {value2} = {resultValue} \n");
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    resultValue = value1 * value2;
                    Console.WriteLine($"Результат: {value1} * {value2} = {resultValue} \n");
                    break;
                case 5:
                    Console.WriteLine("Введите первое число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    resultValue = value1 / value2 * 100;
                    Console.WriteLine($"Результат: {value1} / {value2} * 100 = {resultValue} \n");
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    resultValue = Math.Sqrt(value1);
                    Console.WriteLine($"Результат: Math.Sqrt({value1}) = {resultValue} \n");
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Введенное значение выходит за пределы допустимого диапазона \n");
                    break;
            }

            goto programStart;
        }
    }
}