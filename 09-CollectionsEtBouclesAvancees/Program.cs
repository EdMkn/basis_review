using System;
using System.Collections.Generic;

namespace _09_CollectionsEtBouclesAvancees
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("📚 Collections et boucles avancées");
            Console.WriteLine("----------------------------------");

            // Liste de noms
            List<string> noms = new List<string> { "Alice", "Bob", "Charlie" };
            noms.Add("David");

            Console.WriteLine("Liste des noms:");
            foreach (var nom in noms)
            {
                Console.WriteLine($"- {nom}");
            }

            // Dictionnaire prénom -> âge
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 30;
            ages["Bob"] = 25;
            ages["Charlie"] = 35;

            Console.WriteLine("\nÂges des personnes:");
            foreach (var entry in ages)
            {
                Console.WriteLine($"{entry.Key} a {entry.Value} ans");
            }

            // Recherche dans une liste
            Console.WriteLine("\nRecherche du prénom 'Bob' dans la liste:");
            if (noms.Contains("Bob"))
                Console.WriteLine("Bob est dans la liste !");
            else
                Console.WriteLine("Bob n'est pas dans la liste.");
        }
    }
}
