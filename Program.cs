using System;
using Mentoria_GFT.Entities;

namespace Mentoria_GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Apartamento moradia = new Apartamento("Av GFT, 2999", "Salvador", 86, 2, 1, 80000, 9, "901","B");

            Casa moradia1 = new Casa("Av Babaçu, 155", "Belo Horizonte", 100, 3, 2, 150000, 25);
        
           System.Console.WriteLine("--------------------------");
           System.Console.WriteLine(moradia);
           System.Console.WriteLine("--------------------------");
           System.Console.WriteLine(moradia1);

        }
    }
}
