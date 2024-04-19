using System;

namespace rktowam
{
    class Program
    {
        static void Main(string[] args)
        {
            double a , b, c;

            Console.WriteLine("ax^2+bx+c==0");
            Console.WriteLine("podaj a (z ax)");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b (x bx)");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("podaj c");
            c = Double.Parse(Console.ReadLine());



            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {

                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("pierwiastki to {0} i {1}", x1, x2);
            } else
            {
                Console.WriteLine("brak pierwiastkow rzeczywistych");
            }

        }
    }
}
