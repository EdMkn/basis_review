using System;

namespace _01_Variables
{
    class Program
    {
        static void Main()
        {
            // Déclaration et initialisation de variables de base
            string prenom = "Édouard";
            int age = 28;
            double taille = 1.80;
            bool estMajeur = age >= 18;
            char initiale = 'É';
            string ville = "Paris";

            // Calcul d'une valeur dérivée
            int ageDans10Ans = age + 10;

            // Affichage des variables
            Console.WriteLine("📘 Révision : Variables & Types");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Prénom        : {prenom}");
            Console.WriteLine($"Initiale      : {initiale}");
            Console.WriteLine($"Âge           : {age}");
            Console.WriteLine($"Taille        : {taille} m");
            Console.WriteLine($"Majeur        : {estMajeur}");
            Console.WriteLine($"Ville         : {ville}");
            Console.WriteLine();
            Console.WriteLine($"Dans 10 ans, {prenom} aura {ageDans10Ans} ans et vivra à {ville}.");
        }
    }
}
