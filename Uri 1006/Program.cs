using System;
using System.Globalization;

namespace Uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, m;
            int p1, p2, p3;

            p1 = 2;
            p2 = 3;
            p3 = 5;

            Console.WriteLine();
            Console.Write("Digite a primeira nota : ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite a primeira nota : ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite a primeira nota : ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            m = (a * p1 + b * p2 + c * p3) / (p1 + p2 + p3);

            Console.WriteLine();
            Console.WriteLine("Média = "+m.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
