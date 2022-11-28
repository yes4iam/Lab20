using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate double CicleDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности:");
            CicleDelegate circle = CircleLength;
            double l = circle(r);
            Console.WriteLine(l);

            Console.WriteLine("Площадь круга:");
            circle = CircleArea;
            double a = circle(r);
            Console.WriteLine(a);

            Console.WriteLine("Объем шара:");
            circle = CircleVolume;
            double v = circle(r);
            Console.WriteLine(v);

            Console.ReadKey();

        }

        static double CircleLength(double r) => 2 * Math.PI * r;
        static double CircleVolume(double r) => (4/3) * Math.PI * r*r*r;
        static double CircleArea(double r) => Math.PI * r*r;

    }
}
