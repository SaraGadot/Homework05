using System;
using System.Text;

namespace Task03.StringDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            var text = Console.ReadLine();
            var resultText = StringDistinct(text);
            Console.WriteLine(resultText);
        }
        static string StringDistinct(string text)
        {
            char? prevSymbol = null;
            var resultText = new StringBuilder();
            foreach (var symbol in text)
            {
                if (symbol != prevSymbol)
                {
                    resultText.Append(symbol);
                    prevSymbol = symbol;
                }
            }
            return resultText.ToString();
        }
    }
}
//Задание 3.Создание метода, принимающего строку и возвращающего новую строку, в которой удалены все рядом стоящие повторяющиеся символы


//Что нужно сделать
//Создайте метод, который принимает произвольный текст в виде строки. Этот метод возвращает новую строку, в которой отсутствуют все повторяющиеся,
//рядом стоящие символы.



//Примеры:

//ПППОООГГГООООДДДААА >>> ПОГОДА

//Ххххоооорррооошшшиий деееннннь >>> хороший день



//Регистр символов не имеет значения.



//Советы и рекомендации
//При решении задания вам поможет метод ToLower, который приведёт все символы в строке к нижнему регистру. Этот метод есть у любой строки.


//Что оценивается
//Создан метод, который принимает и возвращает строку.
//В возвращаемой строке нет повторяющихся смежных символов.