using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Доступ запрещен");
            }



            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число нечетное");
            }



            Console.WriteLine("Введите сумму покупки");
            int sum = Convert.ToInt32(Console.ReadLine());

            if (sum < 500)
            {
                Console.WriteLine("Сумма к оплате: " + sum);
            }
            else if (sum >= 500 & sum < 1000)
            {
                Console.WriteLine("Сумма к оплате с учетом скидки 5%: " + sum * 0.95);
            }
            else if (sum >= 1000 & sum < 3000)
            {
                Console.WriteLine("Сумма к оплате с учетом скидки 10%: " + sum * 0.90);
            }
            else if (sum >= 3000)
            {
                Console.WriteLine("Сумма к оплате с учетом скидки 20%: " + sum * 0.80);
            }



            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Год " + year + " является високосным");
            }
            else
            {
                Console.WriteLine("Год " + year + " не является високосным");
            }


            Console.WriteLine("Введите день недели 1-7");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельнеик");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда"); 
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка! Введите число от 1 до 7.");
                    break;
            }



            Console.WriteLine("Введите свет светофора");
            string color = Convert.ToString(Console.ReadLine());

            switch (color)
            {
                case "красный":
                    Console.WriteLine("Стой! Идти нельзя");
                    break;
                case "зеленый":
                    Console.WriteLine("Идите! Переход разрешен");
                    break;
                case "желтый":
                    Console.WriteLine("Приготовьтесь");
                    break;
                default:
                    Console.WriteLine("Некорректный цвет");
                    break;
            }


        }
    }
}
