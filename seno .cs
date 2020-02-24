using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_david
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese n");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese x");
            double x = double.Parse(Console.ReadLine());
            double serie = 0;
            double por = 0;

            for (int i = 0; i <= n; i++)
            {
                double ex = Factorial(2*i+1);
                serie += Math.Pow(-1, i) / ex;
                por += (Math.Pow(-1, i) / ex)* (Math.Pow (x, 2*i + 1));



            }
            Console.WriteLine(por);
        }

        public static double Factorial(double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
