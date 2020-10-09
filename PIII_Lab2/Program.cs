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

            Wyniki wynik = Wyniki.JednoMZ | Wyniki.DwaMZ | Wyniki.ZeroMZ;

            switch (wynik)
            {
                
            }
           
        }
    }
    
}
