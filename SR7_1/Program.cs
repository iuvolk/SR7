using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR7_1
{
    internal class Program
    {

        static double GetSquareTriangle(double a, double b, double c)
        {
            return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            double s1 = GetSquareTriangle(a1, b1, c1);
            double s2 = GetSquareTriangle(a2, b2, c2);

            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
                Console.WriteLine("Площадь треугольников равна");
            Console.ReadKey();
        }
    }
}
