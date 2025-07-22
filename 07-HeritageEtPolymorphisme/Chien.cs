namespace _07_HeritageEtPolymorphisme
{
    public class Chien : Animal
    {
        public Chien(string nom) : base(nom) { }

        public override void Parler()
        {
            Console.WriteLine($"{Nom} aboie : Woof !");
        }
    }
}
