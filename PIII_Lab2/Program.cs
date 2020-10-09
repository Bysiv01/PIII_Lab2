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
            try
            {
                Console.WriteLine("Podaj A");
                string a = Console.ReadLine();
                double aa = double.Parse(a);
                Console.WriteLine("Podaj B");
                string b = Console.ReadLine();
                double bb = double.Parse(b);
                Console.WriteLine("Podaj C");
                string c = Console.ReadLine();
                double cc = double.Parse(c);

                double delta;

                delta = (bb * bb - 4 * aa * cc);

                Console.WriteLine($"Delta wynosi: {delta}");

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
            catch (FormatException)
            {
                Console.WriteLine("któraś z podanych wartości nie jest liczba!");
            }


        }
    }
    
}
