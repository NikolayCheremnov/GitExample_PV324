using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample_PV324
{
    internal class Program
    {
        // IsSimple - функция определения того, является ли число простым или составным
        // вход: number - целое число
        // выход: true если модуль number - простое число, иначе false
        // примечание: 1, 0 считаются как простые
        static bool IsSimple(int number)
        {
            number = Math.Abs(number);
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isSimple = IsSimple(n);
            if (isSimple) {
                Console.WriteLine($"{n} is simple");
            } else
            {
                Console.WriteLine($"{n} is composite number");
            }
        }
    }
}
