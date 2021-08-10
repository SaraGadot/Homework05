using System;

namespace Task04.Progression
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckProgression(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(CheckProgression(new[] { 2, 4, 8 }));
            Console.WriteLine(CheckProgression(new[] { 1, 2, 1, 4 }));
        }
        public static ProgressionKind CheckProgression (int[] numbers)
        {
            if (IsArithmeticProgression(numbers))
            {
                return ProgressionKind.Arithmetic;
            }
            if (IsGeometricProgression(numbers))
            {
                return ProgressionKind.Geometric;
            }
            return ProgressionKind.None;
        }

        public static bool IsArithmeticProgression(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return false;
            }
            var d = numbers[1] - numbers[0];
            for (var i = 2; i < numbers.Length; i++)
            {
                var d2 = numbers[i] - numbers[i-1];
                if (d2 != d)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsGeometricProgression(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return false;
            }
            if (IsZero(numbers))
            {
                return true;
            }
            var d = numbers[1] / (double)numbers[0];
            for (var i = 2; i < numbers.Length; i++)
            {
                var d2 = numbers[i] / (double)numbers[i - 1];
                if (d2 != d)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsZero(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public enum ProgressionKind
    {
        None,
        Arithmetic,
        Geometric
    }
}
//Задание 4.Написание метода, определяющего, является ли последовательность чисел прогрессией


//Что нужно сделать
//Напишите метод, принимающий произвольное количество чисел в виде массива, который определяет, являются ли эти числа арифметической
//или геометрической прогрессией или не являются прогрессией вовсе.


//Что оценивается
//Создан метод, который принимает массив чисел как параметр.
//Метод определяет, являются ли числа в массиве арифметической или геометрической прогрессией или массив не содержит прогрессии.
//Метод возвращает результат в виде строки или перечисления.
