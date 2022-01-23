namespace Abstraindo_um_RPG.src.Entities
{
    public class Wizzard : Hero
    {
        public Wizzard(string Name, int Level, int Hp, int Mp, string HeroType) : base(Name, Level, Hp, Mp, HeroType)
        {
            
        }
        public override string Attack(){
            return this.Name + "Lançou Magia";
        }
        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + "Lançou Magia super efetiva com bonus de ataque de " + Bonus;
            } else {
                return this.Name + "Lançou Magia com força fraca bonus de ataque de " + Bonus;
            }
            
        }
    }
}