using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod2
{
    class Program
    {
        static void GetParamsCub(double a, out double s, out double v)
        {
            s = 6*Math.Pow(a,2);
            v = Math.Pow(a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата (ребро)");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCub(a, out s, out v);
            Console.WriteLine("Площадь куба {0:.00}. Объем куба {1:.00}", s, v);
            Console.ReadLine();
          
        }
    }
}
