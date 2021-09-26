//Homework for lesson 2 Tihomirov Dima
using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание номер один
            //Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Введите перове число: ");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int number_3 = int.Parse(Console.ReadLine());
            if (number_1 < number_2 && number_1 < number_3)
            {
                Console.WriteLine(number_1);
            }
            else if (number_2 < number_1 && number_2 < number_3)
            {
                Console.WriteLine(number_2);
            }
            else
            {
                Console.WriteLine(number_3);
            }

            #endregion
            #region задание номер два
            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.
            int storage = 0;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int number_4 = Convert.ToInt16(Console.ReadLine());

                if (number_4 != 0)
                {
                    if (number_4 % 2 == 0)
                    {
                    }
                    else
                        storage += number_4;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(storage);
            #endregion
            #region задание номер три
            /*Написать программу, которая запрашивает массу и рост человека, 
            вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
            набрать вес или всё в норме.*/
            Console.WriteLine("Введите вес:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            float I = m / (h * h);
            Console.WriteLine("Ваш индекс массы: {0}", I);
            if (age <= 25)
            {
                if (I < 19.5)
                {
                    Console.WriteLine("У вас недостаток веса. Вам нужно набрать массы");
                }
                else if (I > 27.5)
                {
                    Console.WriteLine("У вас переизбыток веса. Вам нужно сбросить массу");
                }
                else
                {
                    Console.WriteLine("У вас все отлично! Поздравляем!");
                }
            }
            else if (age > 25)
            {
                if (I < 20.0)
                {
                    Console.WriteLine("У вас недостаток веса. Вам нужно набрать массу");
                }
                else if (I > 27.9)
                {
                    Console.WriteLine("У вас переизбыток веса. Вам нужно сбросить массу");
                }
                else
                {
                    Console.WriteLine("У вас все отлично! Поздравляем!");
                }
            }


            #endregion
            #region задание номер четыре
            /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел
(Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и
пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.*/
            int attempt = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string l = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string p = Console.ReadLine();
                attempt++;
                if (l == "root" && p == "GeekBrains")
                {
                    Console.WriteLine("Доступ разрешен.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль. Попробуйте еще раз.");
                }
            }
            while (attempt != 3);
            #endregion
        }
    }
}
