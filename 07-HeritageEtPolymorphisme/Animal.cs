namespace _07_HeritageEtPolymorphisme
{
    public class Animal
    {
        public string Nom { get; set; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public virtual void Parler()
        {
            Console.WriteLine($"{Nom} fait un bruit.");
        }
    }
}
