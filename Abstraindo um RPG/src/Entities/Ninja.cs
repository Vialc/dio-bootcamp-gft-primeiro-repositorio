namespace Abstraindo_um_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, int Hp, int Mp, string HeroType) : base(Name, Level, Hp, Mp, HeroType)
        {
        
        }
        public override string Attack(){
            return this.Name + "Jogou shuriken";
        }
    }
}