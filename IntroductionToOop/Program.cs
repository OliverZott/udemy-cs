using IntroductionToOop.Characters.Meele;
using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Worrior druid = new Worrior("Bob The Druid", 100, 5);
            Worrior berserker = new("John The Berserker", 150, 10);

            Axe axe = new();
            druid.Weapon = axe;
            druid.Name = "Blob";
            berserker.Level = 200;

            System.Console.WriteLine("Berserker Level: {0}", arg0: berserker.Level);

            System.Console.WriteLine(druid.ToString() + " Name: " + druid.Name + ". Has weapon: " + druid.Weapon.ToString());
            System.Console.WriteLine(druid.name);

            druid.Greet(berserker.Name);
            berserker.Attack(druid);

        }
    }
}
