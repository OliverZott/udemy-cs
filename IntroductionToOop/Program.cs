using IntroductionToOop.Characters.Meele;

namespace IntroductionToOop
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior goodGuy = new Warrior("Bob the good guy", 119, 5, Enumerations.Faction.GoodGuy);
            Warrior badGuy = new Warrior("John the bad warrior", 100, 5, Enumerations.Faction.BadGuy);

            System.Console.WriteLine(goodGuy.Level);
            badGuy.MoveChar(200);
            goodGuy.MoveChar();
            System.Console.WriteLine(goodGuy);


            /*
            // static method
            Warrior.GetAllDefaultInfromation();

            Warrior druid = new Warrior("Bob The Druid", 100, 5);
            Warrior berserker = new("John The Berserker", 150, 10);
            // usage of chained constructor
            Warrior sam = new("Sam");
            Warrior.GetAllReadOnlyConstants(sam);

            // Check Id and IdCOunter 
            Tools.ColorfulWriteLine(druid.ToString(), ConsoleColor.Blue);
            Tools.ColorfulWriteLine(berserer.ToString(), ConsoleColor.Blue);
            System.Console.WriteLine("Property in Warrior-Class to retrieve Id: " + druid.Id);

            Axe axe = new();
            druid.Weapon = axe;
            druid.Name = "Blob";
            // berserker.Level = 200;

            System.Console.WriteLine("Berserker Level: {0}", arg0: berserker.Level);

            System.Console.WriteLine(druid.ToString() + " Name: " + druid.Name + ". Has weapon: " + druid.Weapon.ToString());
            System.Console.WriteLine(druid.name);

            druid.Greet(berserker.Name);
            berserker.Attack(druid);
            */

        }
    }
}
