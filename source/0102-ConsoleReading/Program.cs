using System;

namespace _0102_ConsoleReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-нибудь:");
            //Console.ReadLine считает текст после нажатия ENTER и сохранит его в переменную 'text'
            var text = Console.ReadLine();
            Console.WriteLine("Вы написали:");
            //Console.WriteLine выведет то, что сохранили в 'text' на экран
            Console.WriteLine(text);

            Console.Read();
        }
    }
}
