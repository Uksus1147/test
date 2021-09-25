//Домашнее задание ученика Тихомирова Дмитрия
using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание номер  один
            //1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою Фамилию:");
            string secondname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой рост:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой вес:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше имя - " + name + "Ваша фамилия - " + secondname + "Ваш возраст - " + age + "Ваш рост - " + height + "Ваш вес - " + weight);
            Console.WriteLine("Ваше имя - {0} Ваша фамилия {1} Ваш возраст - {2}  Ваш рост - {3} Ваш вес - {4}", name, secondname, age, height, weight);
            Console.WriteLine($"Ваше имя - {name} Ваша фамилия {secondname} Ваш возраст - {age} Ваш рост - {height} Ваш вес - {weight}");
            #endregion
            #region задание номер два
            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ)
            //по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Введите вес:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            int h = int.Parse(Console.ReadLine());
            int I = m / (h * h);
            Console.WriteLine("Ваш индекс массы: ", I);
            #endregion
            #region задание номер три
            //Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            // с использованием третьей переменной;
            int number1 = 23;
            int number2 = 27;
            int number3 = number1;
            number2 = number3;
            #endregion

        }
    }
}