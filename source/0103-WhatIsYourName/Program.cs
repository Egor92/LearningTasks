using System;

namespace _0103_WhatIsYourName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Печатаем приветствие
            Console.WriteLine("Здравствуйте");

            Console.Write("Напишите, пожалуйта, ваше имя: ");
            //Включаем залёный цвет
            Console.ForegroundColor = ConsoleColor.Green;
            //Просим написать имя
            //Console.ReadLine считает имя после нажатия ENTER и сохранит имя в переменную 'name'
            var name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Напишите, пожалуйта, вашу фамилию: ");
            //Включаем жёлтый цвет
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Просим написать фамилию
            //Console.ReadLine считает фамилию после нажатия ENTER и сохранит имя в переменную 'surname'
            var surname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            //Печатаем, как вас зовут.
            //Вместо {0} напишится то, что хранится в 'name'
            //Вместо {1} напишится то, что хранится в 'surname'
            Console.Write("Вас зовут {0} {1}", name, surname);

            Console.Read();
        }
    }
}
