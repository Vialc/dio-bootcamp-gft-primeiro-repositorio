namespace Abstraindo_um_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int Hp, int Mp, string HeroType) : base(Name, Level, Hp, Mp, HeroType)
        {
            
        }
        public override string Attack(){
            return this.Name + " Atacou com a sua espada";
        }
    }
}