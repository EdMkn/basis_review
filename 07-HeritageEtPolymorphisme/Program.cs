using System;
using System.Collections.Generic;

namespace _07_HeritageEtPolymorphisme
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🐾 Héritage & Polymorphisme en C#");
            Console.WriteLine("----------------------------------");

            // Liste d'animaux
            List<Animal> animaux = new List<Animal>
            {
                new Chien("Rex"),
                new Chat("Minette"),
                new Chien("Fido"),
                new("Mystère")
            };

            Console.WriteLine("\n🐶 Tous les animaux parlent :");
            foreach (var animal in animaux)
            {
                animal.Parler();  // appel polymorphe
            }
        }
    }
}
