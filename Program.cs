using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_prime_number_task_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, pocket;
            Console.WriteLine("Enter the starting point");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending point");
            y = int.Parse(Console.ReadLine());

            for (int N = x; N <= y; N++)
            { if (N == 0 || N == 1)
                    continue;
                pocket = 1;
                for (int i = 2; i <= N / 2; i++)
                { if (N % i == 0)
                    {
                        pocket = 0;
                        break;
                    }
                }
                if (pocket == 1)
                    Console.WriteLine(N);
            }
            Console.ReadKey();

        }
    }
}
