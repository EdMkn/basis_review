namespace _07_HeritageEtPolymorphisme
{
    public class Chat : Animal
    {
        public Chat(string nom) : base(nom) { }

        public override void Parler()
        {
            Console.WriteLine($"{Nom} miaule : Miaou !");
        }
    }
}
