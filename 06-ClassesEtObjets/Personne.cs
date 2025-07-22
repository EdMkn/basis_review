namespace _06_ClassesEtObjets
{
    public class Personne
    {
        // Propriétés
        public string Prenom { get; set; }
        public int Age { get; set; }

        // Constructeur
        public Personne(string prenom, int age)
        {
            Prenom = prenom;
            Age = age;
        }

        // Méthode d’instance
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m'appelle {Prenom} et j'ai {Age} ans.");
        }

        // Méthode qui renvoie l'année de naissance
        public int AnneeDeNaissance()
        {
            return DateTime.Now.Year - Age;
        }
    }
}
