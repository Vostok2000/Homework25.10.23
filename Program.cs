using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ВСЕ РАЗЛИЧНЫЕ ЦИФРЫ
            string str = Console.ReadLine();
            string result = String.Empty;
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    if (!result.Contains(item))
                    {
                        result += item;
                    }
                }
            }
            if (result == String.Empty)
            {
                result = "NO";
            }
            Console.WriteLine(result);
            Console.ReadKey();
            /* //Повторяющиеся цифры
             string str = Console.ReadLine();
             string numberStr = String.Empty;
             string result = String.Empty;
             foreach (char item in str)
             {
                 if (!result.Contains(item))
                 {
                     result += item;
                 }
             }
             foreach (char item in result)
             {
                 int count = 0;
                 foreach (char symbol  in str)
                 {
                     if(item == symbol)
                     {
                         count++;
                     }
                 }
                 if(count>1 && Char.IsDigit(item))
                 {
                     numberStr += item;
                 }
                 Console.WriteLine(numberStr);
                 Console.ReadKey();  
             }
             //правильное имя переменной 
            string str = Console.ReadLine();
            string pattern = "abcdefghijklmnopqrstuvwxyz0123456789_";
            str = str.ToLower();                            //переводим все буквы в нижний регистр
            bool result = true;                             //задаём логическую переменную
             if (Char.IsDigit(str.First()))                 //проверка "если первый символ - цифра"
             {
                 Console.WriteLine("NO");
             }
             else
             {
                 for (int i = 0; i < str.Length; i++)        //цикл (содержит ли наша строка только допуститмые символы
                 {
                     result = pattern.Contains(str[i]);
                     if (result== false)                     //если есть не допустимый символ
                     {
                         break;                              //идёт завершение цикла for
                     }
                 }
                 if (result)
                 {
                     Console.WriteLine("Yes");
                 }
                 else
                 {
                     Console.WriteLine("NO");
                 }
             }
             Console.ReadKey();
             //СКОЛЬКО РАЗЛИЧНЫХ СИМВОЛОВ
             string str = Console.ReadLine();
             string newStr = String.Empty;           //новая пустая строка
             int k = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 if (!newStr.Contains(str[i]))       //если символа нет в новой строке, то записываем его туда
                 {
                     newStr += str[i];
                     k++;                            //счётчик, сколько новых символов мы записали в newStr
                 }
             }
             Console.WriteLine(k);
             Console.ReadKey();*/

        }
    }
}
