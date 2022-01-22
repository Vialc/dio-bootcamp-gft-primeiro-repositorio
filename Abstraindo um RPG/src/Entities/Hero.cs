namespace Abstraindo_um_RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, int Hp, int Mp, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level, Hp, Mp;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}