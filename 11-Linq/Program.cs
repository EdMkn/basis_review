using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Linq
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🔍 Introduction à LINQ");
            Console.WriteLine("----------------------");

            List<Personne> personnes = new List<Personne>
            {
                new Personne { Nom = "Alice", Age = 30 },
                new Personne { Nom = "Bob", Age = 25 },
                new Personne { Nom = "Charlie", Age = 35 },
                new Personne { Nom = "David", Age = 28 }
            };

            // Requête LINQ : sélectionner les personnes majeures (plus de 29 ans)
            var adultes = from p in personnes
                          where p.Age > 29
                          orderby p.Nom
                          select p;

            Console.WriteLine("Personnes de plus de 29 ans (ordre alphabétique) :");
            foreach (var adulte in adultes)
            {
                Console.WriteLine($"{adulte.Nom} - {adulte.Age} ans");
            }

            // Exemple avec méthodes LINQ (lambda)
            var jeunes = personnes.Where(p => p.Age < 30).OrderBy(p => p.Age);

            Console.WriteLine("\nPersonnes de moins de 30 ans (ordre par âge) :");
            foreach (var jeune in jeunes)
            {
                Console.WriteLine($"{jeune.Nom} - {jeune.Age} ans");
            }
        }
    }

    class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }
    }
}
