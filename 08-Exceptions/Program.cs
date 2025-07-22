using System;

namespace _08_Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("⚠️ Gestion des exceptions en C#");
            Console.WriteLine("--------------------------------");

            try
            {
                Console.Write("Entrez un nombre entier : ");
                string input = Console.ReadLine();
                int nombre = int.Parse(input);

                int resultat = 100 / nombre;
                Console.WriteLine($"100 divisé par {nombre} = {resultat}");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Erreur : vous devez entrer un nombre valide.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ Erreur : division par zéro impossible !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erreur inattendue : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("🔚 Fin du programme.");
            }
        }
    }
}
