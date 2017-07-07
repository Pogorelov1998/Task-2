using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, max;
            Console.WriteLine("¬ведите длинну первой сторны треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            max = a;
            Console.WriteLine("¬ведите длинну второй сторны треугольника");
            b = Convert.ToDouble(Console.ReadLine());
            if (b > max)
                max = b;
            Console.WriteLine("¬ведите длинну третьей сторны треугольника");
            c = Convert.ToDouble(Console.ReadLine());
            if (c > max)
                max = c;
            if (max == a)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    Console.WriteLine("“реугольник пр¤моугольный");
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                    Console.WriteLine("“реугольник тупоугольный");
                else
                    Console.WriteLine("“реугольник остроугольный");
            }
            if ((max == b) && (b != a))
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    Console.WriteLine("“реугольник пр¤моугольный");
                else if (Math.Pow(b, 2) > Math.Pow(a, 2) + Math.Pow(c, 2))
                    Console.WriteLine("“реугольник тупоугольный");
                else
                    Console.WriteLine("“реугольник остроугольный");
            }
            if ((max == c) && (c != a) && (c != b))
            {
                if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    Console.WriteLine("“реугольник пр¤моугольный");
                else if (Math.Pow(c, 2) > Math.Pow(b, 2) + Math.Pow(a, 2))
                    Console.WriteLine("“реугольник тупоугольный");
                else
                    Console.WriteLine("“реугольник остроугольный");
            }
            Console.ReadKey();
        }
    }
}