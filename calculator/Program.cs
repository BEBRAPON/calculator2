using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию: \r\n1) Сложение \r\n2) Вычитание \r\n3) Умножение \r\n4) Деление первого числа на другое \r\n5) Возвести первое число в степень" +
                " \r\n6) Найти квадратный корень \r\n7) Найти процент от числа \r\n8) Найти факториал \r\n9) Выход из калькултора" +
                "\r\nЕсли вы хотите очистить предыдущие вычисления напишите 'clear'.");
                string operaciya = Console.ReadLine();
                switch (operaciya)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите первое число: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат сложения: " + (number1 + number2) + " \r\n");
                            break;
                        }
                    case "clear":
                        Console.Clear();
                        break;
                    case "2":
                        {
                            Console.WriteLine("Введите первое число: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат вычитания: " + (number1 - number2) + " \r\n");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Введите первое число: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат умножения: " + (number1 * number2) + " \r\n");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Введите первое число: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            if (number2 == 0)
                                Console.WriteLine("Ошибка. На 0 делить нельзя\r\n");
                            else
                                Console.WriteLine("Результат деления: " + (number1 / number2) + " \r\n");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Введите число: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите степнь числа: ");
                            double stepen = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Результат возведения в степень: " + (Math.Pow(number, stepen)) + " \r\n");
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Введите число, из которого хотите вывести корень: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Квадратный корень равен: " + (Math.Sqrt(number)) + " \r\n");
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Введите число: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Процент от числа равен: " + (number * 1 / 100) + " \r\n");
                            break;
                        }
                    case "8":
                        {
                            double vspomPeremennaya = 1;
                            Console.WriteLine("Введите число: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            for (double posledChislo = 1; posledChislo <= number; posledChislo++)
                            {
                                vspomPeremennaya = posledChislo * vspomPeremennaya;
                            }
                            Console.WriteLine("Факториал равен: " + vspomPeremennaya + " \r\n");
                            break;
                        }
                    case "9":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Введите верную операцию.\r\n");
                        break;
                }

            }

        }
    }
}
