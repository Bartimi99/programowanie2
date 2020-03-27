using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double wynik = 0.0;
            Mat.OdwrotnaNotacjaPolska onp = new Mat.OdwrotnaNotacjaPolska();
            onp.Parse("2+2*3/(2+2)^2-4");
            wynik = onp.Ocenianie();
            Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            Console.WriteLine("wynik: {0}", wynik);

            Console.WriteLine();
            onp.Parse("sin5");
            wynik = onp.Ocenianie();
            Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            Console.WriteLine("wynik: {0}", wynik);

            Console.WriteLine();
            onp.Parse("abs(-10)");
            wynik = onp.Ocenianie();
            Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            Console.WriteLine("wynik: {0}", wynik);
            Console.WriteLine("");


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                string wyrazenie = "cos 4*";
                wyrazenie += i;
                Oblicz(wyrazenie);
            }

            Console.WriteLine("Koniec programu");
            Console.ReadLine();


        }

        static void Oblicz(string wyrazenie)
        {
            double wynik;
            Mat.OdwrotnaNotacjaPolska onp = new Mat.OdwrotnaNotacjaPolska();
            Console.WriteLine();
            onp.Parse(wyrazenie);
            wynik = onp.Ocenianie();
            Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            Console.WriteLine("wynik: {0}", wynik);
            Console.WriteLine("");
        }
    }
}