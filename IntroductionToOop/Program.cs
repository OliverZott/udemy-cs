using IntroductionToOop.Characters.Meele;
using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior druid = new Warrior("Bob The Druid", 100, 5);
            System.Console.WriteLine(druid);
            Warrior berserker = new("John The Berserker", 150, 10);
            System.Console.WriteLine(berserker);
            // usage of chained constructor
            Warrior Sam = new("Sam");
            System.Console.WriteLine(Warrior.IdCounter);


            Axe axe = new();
            druid.Weapon = axe;
            druid.Name = "Blob";
            // berserker.Level = 200;

            System.Console.WriteLine("Berserker Level: {0}", arg0: berserker.Level);

            System.Console.WriteLine(druid.ToString() + " Name: " + druid.Name + ". Has weapon: " + druid.Weapon.ToString());
            System.Console.WriteLine(druid.name);

            druid.Greet(berserker.Name);
            berserker.Attack(druid);

        }
    }
}
