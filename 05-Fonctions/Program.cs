using System;

namespace _05_Fonctions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🔧 Révision : Fonctions / Méthodes");
            Console.WriteLine("-----------------------------------");

            // Appel de fonctions
            Bonjour("Édouard");
            Bonjour("Claire");

            int resultat = Addition(7, 5);
            Console.WriteLine($"\n7 + 5 = {resultat}");

            int carre = Carre(6);
            Console.WriteLine($"Le carré de 6 est {carre}");

            Console.Write("\nEntrez un nombre pour tester s'il est pair : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(EstPair(n) ? "✅ Ce nombre est pair." : "❌ Ce nombre est impair.");
        }

        // ======= Fonctions définies ci-dessous =======

        // Procédure (pas de return)
        static void Bonjour(string prenom)
        {
            Console.WriteLine($"Bonjour, {prenom} !");
        }

        // Fonction qui renvoie un int
        static int Addition(int a, int b)
        {
            return a + b;
        }

        // Fonction de calcul
        static int Carre(int nombre)
        {
            return nombre * nombre;
        }

        // Fonction booléenne
        static bool EstPair(int nombre)
        {
            return nombre % 2 == 0;
        }
    }
}
