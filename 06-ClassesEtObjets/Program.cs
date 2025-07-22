using System;

namespace _06_ClassesEtObjets
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("👤 Révision : Classes et Objets");
            Console.WriteLine("--------------------------------");

            // Instanciation d’un objet
            Personne p1 = new Personne("Alice", 30);
            Personne p2 = new Personne("Bob", 25);

            // Appel de méthode
            p1.SePresenter();
            Console.WriteLine($"Année de naissance : {p1.AnneeDeNaissance()}");

            p2.SePresenter();
            Console.WriteLine($"Année de naissance : {p2.AnneeDeNaissance()}");
        }
    }
}
