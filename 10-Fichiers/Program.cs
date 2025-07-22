using System;
using System.IO;

namespace _10_Fichiers
{
    class Program
    {
        static void Main()
        {
            string cheminFichier = "user_text.txt";

            Console.WriteLine("Tape des lignes (tape 'exit' pour quitter et sauvegarder) :");

            using (StreamWriter writer = new StreamWriter(cheminFichier))
            {
                string ligne;
                while (true)
                {
                    ligne = Console.ReadLine();
                    if (ligne.ToLower() == "exit")
                        break;

                    writer.WriteLine(ligne);
                }
            }

            Console.WriteLine($"\nContenu sauvegardé dans {cheminFichier} :");
            Console.WriteLine(File.ReadAllText(cheminFichier));
        }
    }
}
