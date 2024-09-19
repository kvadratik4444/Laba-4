using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool LowLetter = false;
            bool HighLetter = false;
            bool number = false;
            bool SpecChar = false;
            int LatASC;
            Console.WriteLine("Введите пароль");
            string str = Console.ReadLine();
            if (str.Length < 6 || str.Length > 12)
            {
                Console.WriteLine("Пароль должен быть от 6 до 12 символов.");
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                LatASC = (int)str[i];
                if (97 <= LatASC && LatASC <= 122) LowLetter = true;
                else if (65 <= LatASC && LatASC <= 90) HighLetter = true;
                else if (48 <= LatASC && LatASC <= 57) number = true;
                else SpecChar = true;
            }
            if (LowLetter && HighLetter && number && SpecChar)
            {
                Console.WriteLine("Пароль подходит.");
            }
            else
            {
                Console.WriteLine("Пароль не подходит.");
            }
        }
    }
}