//***********************************************************
//* Практическая работа № 11                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Title = "Практическая работа №11";
                    Console.WriteLine("Здравсвтвуйте!");
                    Console.WriteLine("Введите строку - ");
                    string text = Console.ReadLine();
                    if (String.IsNullOrEmpty(text))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Строка пустая, вы ничего не ввели!");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {

                    }
                    Console.WriteLine("Хотите продолжить? (да/нет)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "да") break;
                }
                catch(Exception ex)
                {
                    Console.Write("Что-то пошло не так: " + ex.Message);
                }
                Console.ReadKey();
    }
        } } }
