using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Chyba: Musíš zadat přesně 3 čísla jako vstup.");
            return;
        }

        double cislo1, cislo2, cislo3;

        try
        {
            cislo1 = double.Parse(args[0]);
            cislo2 = double.Parse(args[1]);
            cislo3 = double.Parse(args[2]);
        }
        catch
        {
            Console.WriteLine("Chyba: Všechny vstupy musí být čísla.");
            return;
        }

        try
        {
            double soucet = cislo1+cislo2+cislo3;
            double soucin = cislo1*cislo2*cislo3;

            // třetí číslo je nula
            if (cislo3 == 0)
            {
                Console.WriteLine("Chyba: Nelze dělit nulou.");
                return;
            }

            double podil = (cislo1+cislo2)/cislo3;

            // výstup výsledků
            Console.WriteLine($"součet: {soucet}");
            Console.WriteLine($"součin: {soucin}");

            // podíl je příliš velký, nebo malý
            if (double.IsInfinity(podil))
            {
                Console.WriteLine("podíl je příliš velký na zobrazení.");
            }
            else
            {
                Console.WriteLine($"podíl: {podil}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"chyba: {ex.Message}");             // obecná chyba
        }
    }
}
