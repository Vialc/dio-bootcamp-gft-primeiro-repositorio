namespace Abstraindo_um_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, int Hp, int Mp, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.HeroType = HeroType;
        }
    }
}