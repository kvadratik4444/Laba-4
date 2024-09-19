using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace task__1
{
    internal class Program
    {
        public static int F1(int[] arr)
        {
            int MaxEl = arr[0];
            int MinEl= arr[0];
            int N = arr.Length;
            for (int i = 1; i < N; i++)
            {
                if (arr[i] > MaxEl) MaxEl = arr[i];
                if (arr[i] < MinEl) MinEl = arr[i];
            }
            return F2(MinEl, MaxEl);
        }
        public static int F2(int MinEl, int MaxEl)
        {
            return MinEl * MaxEl;
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(F1(arr));
        }
    }
}
