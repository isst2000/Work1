using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace equation
{
    class Equation
    {
        static double coef_input() //function of getting correct coef
        {
            double res;
            bool flag;
            do
            {
                flag = double.TryParse(Console.ReadLine(), out res);
                if (!flag)
                    Console.Write("Incorrect input. Try Again: ");
            } while (!flag);
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Solving equation Ax^2+Bx+C=0\n");
            Console.Write("Enter coef A: ");
            double A = coef_input();
            Console.Write("Enter coef B: ");
            double B = coef_input(); 
            Console.Write("Enter coef C: ");
            double C = coef_input(); 
            
            double d = B * B - 4 * A * C; //determining a discriminant
            Console.WriteLine("\nDiscriminant is        {0}", d);

            if (d < 0) //d < 0, no real solution
                Console.WriteLine("No real solution.");
            else if (d == 0) //d == 0, the only solution
                Console.WriteLine("It's only one solution {0}", -B / 2 / A);
            else //d > 0, both solutions
            {
                d = Math.Sqrt(d);
                Console.WriteLine("One solution is        {0}", (-B - d) / 2 / A);
                Console.WriteLine("Another solution is    {0}", (-B + d) / 2 / A);
            }

            Console.ReadLine(); //delay
        }
    }
}
