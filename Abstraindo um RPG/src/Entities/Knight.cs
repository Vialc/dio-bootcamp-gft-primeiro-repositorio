namespace Abstraindo_um_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int Hp, int Mp, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Atacou com a sua espada";
        }
    }
}