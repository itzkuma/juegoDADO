using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_david
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese x");
            double x = int.Parse(Console.ReadLine());
            double serie = 0;

            for (int i= 0; i<=n; i++)
            {
                 double ex = Factorial(i);
                 serie += Math.Pow(x, i)/ex;


            }
            Console.WriteLine(serie);
        }

        public static double Factorial (double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
