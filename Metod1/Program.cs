using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod1
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double pp = (a + b + c) / 2;
            double Ss = Math.Sqrt(pp * ((pp - a) * (pp) - b) * (pp - c));
            return Ss;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double sq1 = GetSquare(x1, y1, z1);
            
            Console.WriteLine("Введите стороны второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double sq2 = GetSquare(x2, y2, z2);            

            if (sq1 > sq2)
                Console.WriteLine("Сравниваем {0:.00} и {1:.00}. Вывод - площадь первого треугольника больше", sq1, sq2);
            else
                if (sq1 < sq2)
                Console.WriteLine("Сравниваем {0:.00} и {1:.00}. Вывод - площадь второго треугольника больше", sq1, sq2);
            else
                if (sq1 == sq2)
                Console.WriteLine("Сравниваем {0:.00} и {1:.00}. Вывод - площади равны", sq1, sq2);
            else                
            Console.WriteLine("Некорректно введены стороны одного из треугольников: 1-го ({0:.00}) или 2-го ({1:.00})", sq1, sq2);

            Console.ReadKey();
        }
    }
}
