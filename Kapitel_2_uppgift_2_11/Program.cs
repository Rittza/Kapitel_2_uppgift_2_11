using System;

namespace Kapitel_2_uppgift_2_11
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine( "Hur många meter hoppade alma?");
            string Almatext = Console.ReadLine();
            int alma = int.Parse(Almatext);
            int Elin = alma + 1;
            Console.WriteLine( "Elin hoppade " + Elin + " meter vilket innebär att hon vann med 1 meter "); 
        }
    }
}
