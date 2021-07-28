using System;

namespace Task02.StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу: ");
            var text = Console.ReadLine();
            var word = MinWord(text);
            Console.WriteLine($"Слово с минимальной длиной: '{word}'");
            MaxWords(text);

            
        }
        static string MinWord(string text)
        {
           
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                return "";
            }
            var minword = words[0];
            for (var i = 0; i < words.Length; i++)
            {
                // Console.WriteLine($"minWord={minword}, words[i]={words[i]}, {string.Compare(words[i], minword)}");
                if (words[i].Length < minword.Length) 
                {
                    minword = words[i];
                
                }
            }
            //Console.WriteLine(MinWord);
            return minword;
        }

        static string[] MaxWords(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var maxLength = 0;
            foreach (var word in words)
            {
                if (maxLength < word.Length)
                {
                    maxLength = word.Length;
                }

            }
            
            Console.WriteLine(maxLength);
            return null;
        }
    }
}
//Задание 2.Создание методов, которые принимают текст и возвращают слова


//Что нужно сделать
//Создайте два метода:

//Первый метод принимает строку с текстом и возвращает строку, содержащую слово с минимальной длиной.
//Второй метод также принимает на вход текст, но возвращает одно или несколько слов с максимальной длиной.


//Советы и рекомендации
//У класса строки есть метод Split, который поможет разбить текст на слова.
//У метода Split есть параметр options типа StringSplitOptions, который позволит избавится от пустых строк при разбиении. Подробнее о StringSplitOptions.


//Что оценивается
//Оба метода принимают строку как параметр.
//Один из методов возвращает строку, которая содержит слово с минимальной длиной.
//Один из методов возвращает массив или коллекцию строк. Каждая строка имеет такую же длину, как и самое длинное слово в тексте.
