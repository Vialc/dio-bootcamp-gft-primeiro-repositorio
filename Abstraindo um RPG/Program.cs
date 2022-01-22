using Abstraindo_um_RPG.src.Entities;

namespace Abstraindo_um_RPG{

    class Program {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 25, 255, 35, "Knight");
            Wizzard jenica = new Wizzard("Jenica", 23, 195, 170, "White Wizard");
            Ninja marcos = new Ninja("Marcos", 25, 200, 150, "Ninja");
            BlackWizard morbius = new BlackWizard("Morbius", 25, 195, 178, "Black Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(marcos.Attack());
            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(jenica.Attack(7));
        }
        
    }
}