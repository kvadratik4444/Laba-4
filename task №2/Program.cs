using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__2
{
    internal class Program
    {
        public static void F1(double money)
        {
            double profit = money * Math.Pow(1.17, 3);
            Console.WriteLine($"\nВы можете воспользоваться стандартным вкладом нашего банка! Вложив сумму остатка {money} на 3 года по 17% годовых Вы получите прибыль {profit}. Для активации вклада войдите в мобильное приложенние!");
        }
        static void Main(string[] args)
        {
            var people = new Dictionary<string, double>()
            {
                { "Маша", 10000},
                { "Петя", 30000},
                { "Вася", 100000}
            };
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите сумму");
            double money = Convert.ToDouble(Console.ReadLine());
            if (people.ContainsKey(name)) 
            {
                people[name] += money;
                Console.WriteLine($"\n{name}, Ваш баланс счета изменен! Текуший баланс {people[name]}");
            }
            else
            {
                people.Add(name, money);
                Console.WriteLine($"\nБлагодарим, что вы стали клиентом нашего банка! {name}, Ваш баланс счета изменен! Текуший баланс {people[name]}");
            }
            F1(people[name]);
        }
    }
}
