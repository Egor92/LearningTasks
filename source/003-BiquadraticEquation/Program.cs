using System;

namespace _003_BiquadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напечатаем подсказку о том, что биквадратное уравнение имеет вид a*x^2 + b*x + c = 0
            Console.WriteLine("биквадратное уравнение - это уравнение вида 'a*x^4 + b*x^2 + c = 0'");

            Console.WriteLine("Введите 'a'");
            //Просим ввести число 'a'
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 'b'");
            //Просим ввести число 'b'
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 'c'");
            //Просим ввести число 'c'
            var c = Convert.ToDouble(Console.ReadLine());


            //Решение писать тут.....
            //Алгоритм и формулы находятся по этой ссылке
            //https://ru.wikipedia.org/wiki/Уравнение_четвёртой_степени#.D0.91.D0.B8.D0.BA.D0.B2.D0.B0.D0.B4.D1.80.D0.B0.D1.82.D0.BD.D0.BE.D0.B5_.D1.83.D1.80.D0.B0.D0.B2.D0.BD.D0.B5.D0.BD.D0.B8.D0.B5
            //Не забудь добавить проверку на a==0


            //Для завершения програмы нужно будет нажать любую клавишу
            Console.Read();
        }
    }
}
