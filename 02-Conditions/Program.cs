using System;

namespace _02_Conditions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🧪 Révision : Conditions");
            Console.WriteLine("------------------------");

            // Demande à l'utilisateur un âge
            Console.Write("Quel est ton âge ? ");
            string saisie = Console.ReadLine();
            int age;

            if (!int.TryParse(saisie, out age))
            {
                Console.WriteLine("❌ Entrée invalide. Veuillez entrer un nombre entier.");
                return;
            }

            // Conditions classiques
            if (age < 0)
            {
                Console.WriteLine("Tu n'es même pas encore né ? 👶");
            }
            else if (age < 18)
            {
                Console.WriteLine("Tu es mineur.");
            }
            else if (age < 60)
            {
                Console.WriteLine("Tu es adulte.");
            }
            else
            {
                Console.WriteLine("Tu es senior.");
            }

            // Switch classique
            Console.Write("Entre une note de 0 à 5 ");
            string noteStr = Console.ReadLine();
            int note = int.TryParse(noteStr, out int n) ? n : -1;

            switch (note)
            {
                case 5:
                    Console.WriteLine("🌟 Excellent !");
                    break;
                case 4:
                    Console.WriteLine("👍 Très bien !");
                    break;
                case 3:
                    Console.WriteLine("✔️ Bien.");
                    break;
                case 2:
                    Console.WriteLine("😐 Peut mieux faire.");
                    break;
                case 1:
                case 0:
                    Console.WriteLine("❌ Échec.");
                    break;
                default:
                    Console.WriteLine("⛔ Note invalide.");
                    break;
            }

            // Demande à l'utilisateur un âge
            Console.Write("Quel est ton prénom ? ");
            string prenom = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(prenom))
            {
                char premiereLettre = char.ToUpper(prenom[0]);

                if (premiereLettre >= 'A' && premiereLettre <= 'C')
                {
                    Console.WriteLine("Ton prénom commence tôt dans l'alphabet.");
                }
                else if (premiereLettre >= 'D' && premiereLettre <= 'L')
                {
                    Console.WriteLine("Ton prénom est bien équilibré.");
                }
                else if (premiereLettre >= 'M' && premiereLettre <= 'Z')
                {
                    Console.WriteLine("Ton prénom est en fin de classement !");
                }
                else
                {
                    Console.WriteLine("Lettre non reconnue !");
                }
                Console.WriteLine($"Première lettre : {premiereLettre}");
            }
            else
            {
                Console.WriteLine("❌ Tu n'as pas entré de prénom !");
            }



        }
    }
}
