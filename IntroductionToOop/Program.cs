using IntroductionToOop.Characters;
using IntroductionToOop.Characters.Interfaces;
using IntroductionToOop.Characters.Meele;
using IntroductionToOop.Characters.Spellcaster;
using System.Collections.Generic;

namespace IntroductionToOop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Interface and enum example
            System.Console.WriteLine(" --------------------------- Interface and enum example --------------------------- ");
            Warrior goodGuy = new Warrior("Bob the good guy", 119, 5, Enumerations.Faction.GoodGuy);
            Warrior badGuy = new Warrior("John the bad warrior", 100, 5, Enumerations.Faction.BadGuy);

            System.Console.WriteLine(goodGuy.Level);
            //badGuy.MoveChar(200);
            //goodGuy.MoveChar();
            System.Console.WriteLine(goodGuy);



            //  Abstract class
            System.Console.WriteLine(" --------------------------- Abstract class example --------------------------- ");
            Mage dura = new("Dura");
            dura.NumberA = 2;
            dura.NumberB = 3;
            dura.AddTwoNumbers();
            goodGuy.NumberA = 2;
            goodGuy.NumberB = 3;
            goodGuy.AddTwoNumbers();



            // Polymorphism example
            System.Console.WriteLine(" --------------------------- Polymorphism example --------------------------- ");
            Character dude1 = new Warrior("dude1");
            Mage dude2 = new("dude2");
            List<Character> characters = new();
            characters.Add(dude1);
            characters.Add(dude2);
            characters.ForEach(i => System.Console.WriteLine(i.Name + " / " + i.GetType()));

            foreach (Character character in characters)
            {
                if (character is Warrior)
                {
                    Warrior tempWarrior = (Warrior)character;
                    System.Console.WriteLine(tempWarrior.GetType());
                }
            }

            PerformGreeting(characters);



            // IEnumerable Example
            Character[] charactersArray = new Character[2];
            charactersArray[0] = dude1;
            charactersArray[1] = dude2;

            PerformGreeting(charactersArray);       // Not working with 'List<Character>' in Method


            List<IDoMath> mathList = new();
            // mathList.Add(dude1);     // not working cause no function with IDoMath is inherited
            mathList.Add(dude2);



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

        public static void PerformGreeting(IEnumerable<Character> characters)
        {
            foreach (var item in characters)
            {
                item.Greetings("Olli");
            }
        }
    }
}
