using System;
using System.Collections;
using System.IO;

namespace lesson_6
{
    #region задание номер один
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    public delegate double Fun(double x);
    class Program
    {
        private static double a;

        // Создаем метод, который принимает делегат
        // То есть на практике, этот метод сможет принимать любой метод
        // с такой же сигнатурой как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sinus(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void  Main()
        {
            Table(delegate (double x) { return a * x * x; }, 0, 3);
            Console.WriteLine("Таблица функции a*sin(x):");
           Table(delegate (double x) { return a * Math.Sin(x); }, 0, 3);

        }
        
        #endregion
    #region задание номер два
        //  Переделать программу Пример использования коллекций для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        static void Main(string[] args)
        {

            int fivekurs = 0;
        int sixkurs = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();


        StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while(!sr.EndOfStream)
            {
                try {
                    string[] s = sr.ReadLine().Split(';');
        // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
        list.Add(s[1]+" "+s[0]);// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) fivekurs++; else sixkurs++;
                }
                catch
                {
                }
            }
            sr.Close();
list.Sort();
Console.WriteLine("Всего студентов:{0}", list.Count);
Console.WriteLine("Студенты на 6 курсе:{0}", sixkurs);
Console.WriteLine("Студенты на 5 курсе:{0}", fivekurs);




        }
    }

        #endregion
    }


