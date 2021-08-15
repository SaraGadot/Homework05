using System;

namespace Task05.Akkerman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m:");
            var m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n:");
            var n = Convert.ToInt32(Console.ReadLine());

            var akkerman = Akkerman(m, n);
            Console.WriteLine($"Аккерман = {akkerman}");

        }
        public static int Akkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            if (m > 0 && n > 0)
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }
            throw new Exception($"Невалидные параметры: {n}, {m}");
        }
    }
}
//Задание 5.Написание функции Аккермана с применением рекурсии


//Что нужно сделать
//Напишите метод, принимающий два числа ― n и m. Этот метод вычисляет функцию Аккермана и возвращает результат в виде числа.


//Советы и рекомендации
//Задание можно решить и без рекурсии, воспользовавшись классом Stack.


//Что оценивается
//Создан метод, который принимает два числа как параметры.
//Параметры имеют названия n и m.
//Результат метода ― число, полученное после вычисления функции Аккерамана.