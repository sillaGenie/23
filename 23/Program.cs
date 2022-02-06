using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            object n = Convert.ToInt32(Console.ReadLine());
            int r = FactorialAsync(n).Result;
            Console.WriteLine(r);
        }
        static  int Factorial(object n)
        {
            int x=(int)n;
            int c = 1;
            while (x>1)
            {
                c *= x--;
            }
            return c;

        }
        static async Task<int> FactorialAsync(object n)
        {
            int result = await Task.Run(() => Factorial(n));
            return result;
        }
    }
}

