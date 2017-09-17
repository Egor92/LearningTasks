using System;

namespace _001_LinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напечатаем подсказку о том, что линейное уравнение имеет вид a*x + b = 0
            Console.WriteLine("Линейное уравнение - это уравнение вида 'a*x + b = 0'");

            Console.WriteLine("Введите 'a'");
            //Просим ввести число 'a'
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 'b'");
            //Просим ввести число 'b'
            var b = Convert.ToDouble(Console.ReadLine());

            //Решаем уравнение
            var x = -b / a;

            //Выводим решение на экран
            Console.WriteLine($"Решение: x={x}");

            //Для завершения програмы нужно будет нажать любую клавишу
            Console.Read();
        }
    }
}

//Задача:
//Попробуй запустить и задать a=0
//Что произойдёт? Почему?
//Реализуй проверку на случаи a==0, b==0 так, как это описано на википедии в разделе 'Линейное уравнение одной переменной':
//https://ru.wikipedia.org/wiki/Линейное_уравнение#.D0.9B.D0.B8.D0.BD.D0.B5.D0.B9.D0.BD.D0.BE.D0.B5_.D1.83.D1.80.D0.B0.D0.B2.D0.BD.D0.B5.D0.BD.D0.B8.D0.B5_.D0.BE.D0.B4.D0.BD.D0.BE.D0.B9_.D0.BF.D0.B5.D1.80.D0.B5.D0.BC.D0.B5.D0.BD.D0.BD.D0.BE.D0.B9
