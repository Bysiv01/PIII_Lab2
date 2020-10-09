using System;

namespace PIII_Lab2
{
    class Program
    {
        enum Wyniki
        {
            JednoMZ,
            DwaMZ,
            ZeroMZ,
        }

        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta;

            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Convert.ToDouble(Console.ReadLine());

            delta = (b * b - 4 * a * c);

            Console.WriteLine($"Delta jest rowna: {delta}");

            Wyniki wyniki = Wyniki.ZeroMZ;
            wyniki |= Wyniki.JednoMZ;
            wyniki |= Wyniki.DwaMZ;

            if (delta == 0)
            {
                wyniki = Wyniki.JednoMZ;
            }
            else if (delta > 0)
            {
                wyniki = Wyniki.DwaMZ;
            }
            else
            {
                wyniki = Wyniki.ZeroMZ;
            }


            switch (wyniki)
            {
                case Wyniki.ZeroMZ:
                    Console.WriteLine("Jest 0 miejsc zerowych");
                    break;
                case Wyniki.JednoMZ:
                    Console.WriteLine("Jest 1 miejsce zerowe");
                    break;
                case Wyniki.DwaMZ:
                    Console.WriteLine("Są 2 miejsca zerowe");
                    break;
            }
        }
    }
    
}
