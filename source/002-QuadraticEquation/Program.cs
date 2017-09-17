using System;

namespace _002_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напечатаем подсказку о том, что квадратное уравнение имеет вид a*x^2 + b*x + c = 0
            Console.WriteLine("Квадратное уравнение - это уравнение вида 'a*x^2 + b*x + c = 0'");

            Console.WriteLine("Введите 'a'");
            //Просим ввести число 'a'
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 'b'");
            //Просим ввести число 'b'
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 'c'");
            //Просим ввести число 'c'
            var c = Convert.ToDouble(Console.ReadLine());

            //Находим дискриминант (Дискриминант = b*b-4ac)
            var discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант={discriminant}");

            //Если дикриминант меньше нуля, то действительных корней нет
            if (discriminant < 0)
            {
                //Выводим решение на экран
                Console.WriteLine("Решение: Действительных корней нет");
            }
            //Если дикриминант равен нулю, то существует один действительный корень
            else if (discriminant == 0)
            {
                //Находим корень
                var x = -b / (2 * a);
                //Выводим решение на экран
                Console.WriteLine($"Решение: x={x}");
            }
            //В остальных случаях дискриминант больше нуля и существует два решения уравнения
            else
            {
                //Находим корень
                var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                //Выводим решение на экран
                Console.WriteLine($"Решение: x1={x1}, x2={x2}");
            }

            //Для завершения програмы нужно будет нажать любую клавишу
            Console.Read();
        }
    }
}

//Задача:
//Попробуй запустить и задать a=0
//Что произойдёт? Почему?
//Добавь проверку на случаЙ a==0. Просто напиши сообщение, что 'a' не может быть равно нулю и выйди из программы
