using System;
using System.Reflection;

class Program
{
    #region задание номер один
    //С помощью рефлексии выведите все свойства структуры DateTime.
    static void Main()
    {
        Type tipe = typeof(DateTime);
        foreach (var prop in tipe.GetProperties())
            Console.WriteLine(prop.Name);
    }
    #endregion

}
