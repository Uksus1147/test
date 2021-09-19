using System;

namespace lesson_5
{
    class Message
    {
        private static string[] separators = { ",", ".", "?", ";", ":", " " };
    public static void PrintWordsn(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
        public static void Delete(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Substring(words[i].Length - 1, 1) != "й")
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
        public static void Serch(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int max = 0;
            string answer = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    answer = words[i];
                }
            }
            Console.WriteLine(answer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region задание номер один
            //Создать программу, которая будет проверять корректность ввода логина.
            //Корректным логином будет строка от 2 до 10 символов, 
            //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой
            string name = "dima228";
            if (name.Length < 2 || name.Length > 10)
            {
                Console.WriteLine("Login is incorrect");
            }

            if (!Char.IsDigit(name[0]))
            {
                Console.WriteLine("Login is incorrect");
            }

            bool correct = true;

            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetterOrDigit(name[i]))
                {
                    correct = false;
                    break;
                }
            }

            if (correct)
            {
                Console.WriteLine("Login is correct");
            }
            else
            {
                Console.WriteLine("Login is incorrect");
            }
            
            #endregion
            #region задание номер два
            //Разработать статический класс Message, содержащий следующие статические методы для обработки
            //текста:
            //а) Вывести только те слова сообщения, которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            string message = "Я сегодня пил вкусный чай с хлебом в форме паралелепипеда";
            Message.PrintWordsn(message);
            Console.WriteLine("=============================");
            Message.Delete(message);
            Console.WriteLine("=============================");
            Message.Serch(message);

            #endregion
        }
    }
}
