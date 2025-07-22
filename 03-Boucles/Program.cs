using System;
using System.Collections.Generic;

namespace _03_Boucles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🔁 Révision : Boucles en C#");
            Console.WriteLine("---------------------------");

            // ======= Boucle FOR =======
            Console.WriteLine("\n📌 Boucle for : Afficher les nombres de 1 à 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            // ======= Boucle WHILE =======
            Console.WriteLine("\n\n📌 Boucle while : Deviner un nombre (entre 1 et 5)");

            Random rnd = new Random();
            int secret = rnd.Next(1, 6);
            int essai = 0;

            while (essai != secret)
            {
                Console.Write("Devine le nombre : ");
                string input = Console.ReadLine();
                int.TryParse(input, out essai);

                if (essai != secret)
                    Console.WriteLine("❌ Mauvais choix. Essaie encore !");
            }

            Console.WriteLine("✅ Bravo ! Tu as trouvé le nombre !");

            // ======= Boucle DO-WHILE =======
            Console.WriteLine("\n📌 Boucle do-while : Saisir un mot jusqu'à taper 'stop'");

            string mot;
            do
            {
                Console.Write("Tape un mot (ou 'stop' pour quitter) : ");
                mot = Console.ReadLine();
            }
            while (mot.ToLower() != "stop");

            // ======= Foreach sur un tableau =======
            Console.WriteLine("\n📌 Boucle foreach : Afficher un tableau de prénoms");

            string[] prenoms = { "Alice", "Bob", "Charlie" };

            foreach (string p in prenoms)
            {
                Console.WriteLine($"Bonjour, {p} !");
            }
        }
    }
}
