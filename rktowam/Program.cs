using System;

namespace rktowam
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 0, c = -9;

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {

                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("pierwiastki to {0} i {1}", x1, x2);
            }

        }
    }
}
