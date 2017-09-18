using System;

namespace _0104_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пишем текст загадки
            Console.WriteLine("Отгадайте загадку:");
            Console.WriteLine("Не ездок, а со шпорами,");
            Console.WriteLine("Не будильник, а всех будит");

            Console.Write("Ответ: ");
            //Пишем ответ на загадку
            var answer = Console.ReadLine();

            //Если мы написали, что ответ "петух"
            if (answer == "петух")
            {
                //...то зелёным цветом пишем, что ответ верный!
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Верно! Это петух!");
            }
            else
            {
                //...иначе ответ неверный, и красным цветом пишем об этом
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно! Это петух");
            }

            Console.Read();
        }
    }
}
