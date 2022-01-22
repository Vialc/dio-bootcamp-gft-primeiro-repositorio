namespace Abstraindo_um_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, int Hp, int Mp, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Jogou shuriken";
        }
    }
}