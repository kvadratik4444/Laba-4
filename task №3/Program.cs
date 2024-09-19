using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            int MaxAnsLenght = 0;
            int AnsLenght = 0;
            string x = "";
            string ans = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    x += str[i];
                    AnsLenght++;
                }
                else
                {
                    if (MaxAnsLenght < AnsLenght)
                    {
                        ans = x;
                        MaxAnsLenght = AnsLenght;
                    }
                    x = "";
                    AnsLenght = 0;
                }                
            }
            Console.WriteLine(ans);
        }
    }
}
