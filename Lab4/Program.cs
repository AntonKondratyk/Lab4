using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int Sqr(int val)
        {
            int result = 0;
            for (int i = 1; i <= 2 * val - 1; i = i + 2)
                result += i;
            return result;
        }
        static void Main(string[] args)
        {
            int val = 9;
            for (int i = 1; i <= val; i++)
                Console.WriteLine(i + ": " + Sqr(i));
            Console.ReadKey(true);
        }
        /*static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                    //break;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);
            }
            Console.ReadKey();
        }*/
    }
}
