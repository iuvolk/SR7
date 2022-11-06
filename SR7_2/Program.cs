using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR7_2
{
    internal class Program
    {
        static void GetParamsCube(double a, out double s, out double v)
        {
            s = 6*Math.Pow(a,2);
            v = Math.Pow(a,3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double x = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCube(x, out s, out v);
            Console.WriteLine("{0:.00},{1:.00}", s, v);
            Console.ReadKey();
        }
    }
}
