using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    struct Complex
    {
        public double re;

        public double im;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public Complex Proizved(Complex x)
        {
            Complex y;
            y.re = re * x.re;
            y.im = im * x.im;
            return y;
        }
        public override string ToString()
        {
            return $"{re} + {im}";
        }
    }
    class Programm 
    { 

        static void Main(string[] args)

        {
            #region задание номер один
            //1.
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            int number = 0;
            Console.Write("Введите действительную часть первого комплесного числа: ");
            Complex comlex1;
            comlex1.re = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплесного числа: ");
            comlex1.im = double.Parse(Console.ReadLine());
            Console.WriteLine($"Первое комплексное число : z1={comlex1.re}+{comlex1.im}");
            Console.WriteLine("Введите действительную часть второго комплесного числа: ");
            Complex comlex2;
            comlex2.re = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплесного числа: ");
            comlex2.im = double.Parse(Console.ReadLine());
            Console.WriteLine($"Второе комплексное число : z1={comlex2.re}+{comlex2.im}");
            do
            {
                Console.WriteLine("Введите цифру 1 - для сложения комплексных чисел\nВведите цифру 2 - для вычитания комплексных чисел\nВведите циру 3 - для произведения комплексных чисел");
                number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        break;
                    case 1:
                        Complex complexsum = comlex1.Plus(comlex2);
                        Console.WriteLine($"Сумма комплексных чисел: {comlex1} + {comlex2} = {complexsum}\n============================");
                        break;

                    case 2:
                        Complex complexmin = comlex1.Minus(comlex2);
                        Console.WriteLine($"Разность комплексных чисел {comlex1} - {comlex2} = {complexmin}");
                        break;

                    case 3:
                        Complex complexpr = comlex1.Proizved(comlex2);
                        Console.WriteLine($"Произведение компексного числа{comlex1} * {comlex2} = {complexpr}");
                        break;


                    default:
                        Console.WriteLine("Неккоректный вод задачи\nПопробуйте снова");
                        return;

                }
            }
            while (number != 0);
            #endregion
            #region задание номер два
            //С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse.
            int x = 0;
            int y;
            int z;
            bool flag;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                flag = int.TryParse(Console.ReadLine(), out y);
                if (flag)
                {
                    z = y;
                    if (z == 0) 
                    { 
                        Console.WriteLine("Сумма нечетных введений чисел {0}", x);
                        break;
                    }
                    x = (z % 2 == 0 || z < 0) ? x : x + z;
                }

                
                else
                {
                    Console.WriteLine("Данные были введены некоректно");
                }
            }
            #endregion
        }
    }
}
