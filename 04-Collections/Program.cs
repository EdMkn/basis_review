using System;
using System.Collections.Generic;

namespace _04_Collections
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("📦 Révision : Collections en C#");
            Console.WriteLine("--------------------------------");

            // ======= Tableau (Array) =======
            string[] fruits = { "Pomme", "Banane", "Cerise" };

            Console.WriteLine("\n🍎 Tableau de fruits (array) :");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"- {fruits[i]}");
            }

            // ======= Liste dynamique (List<string>) =======
            List<string> animaux = new List<string>();
            animaux.Add("Chien");
            animaux.Add("Chat");
            animaux.Add("Tigre");

            Console.WriteLine("\n🐾 Liste d'animaux (List) :");
            foreach (string animal in animaux)
            {
                Console.WriteLine($"- {animal}");
            }

            // ======= Manipulations de liste =======
            animaux.Remove("Chat");
            animaux.Insert(1, "Ours");

            Console.WriteLine("\n🔧 Liste après modifications :");
            foreach (var a in animaux)
            {
                Console.WriteLine($"- {a}");
            }

            // ======= Recherche dans la liste =======
            Console.Write("\nQuel animal veux-tu chercher ? ");
            string recherche = Console.ReadLine();

            if (animaux.Contains(recherche))
                Console.WriteLine($"✅ {recherche} est dans la liste !");
            else
                Console.WriteLine($"❌ {recherche} n'est pas présent.");
        }
    }
}
