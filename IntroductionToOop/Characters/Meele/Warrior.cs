﻿using IntroductionToOop.Enumerations;

namespace IntroductionToOop.Characters.Meele

{
    public class Warrior : Character
    {

        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTHPOINTS = 100;

        public readonly int id;


        // Constructor
        public Warrior(string name)
            : this(name, DEFAULT_HEALTHPOINTS, DEFAULT_DAMAGE, Faction.GoodGuy)
        {
        }

        public Warrior(string name, int healthpoints, int damage, Faction faction)
        {
            this.Name = name;
            HealthPoints = healthpoints;
            this.Damage = damage;
            this.Faction = faction;
            Warrior.IdCounter++;
            this.id = IdCounter;

            switch (faction)
            {
                case Faction.GoodGuy:
                    this.Level = 1;
                    break;
                case Faction.BadGuy:
                    this.Level = 2;
                    break;
                default:
                    break;
            }

        }


        // Properties
        public int Id
        {
            get { return id; }
            // set { id = value; }  // read-only field cannot be set from outside, only directly on field in class!
        }


        public override string ToString()
        {
            return base.ToString() + " - Id: " + id + " / Name: " + this.Name + " (IdCounter: " + IdCounter + ").";
        }


        public void Greet(string name)
        {
            System.Console.WriteLine($"{this.name} says \"Hello\" to {name}");
            System.Console.WriteLine($"{Name} says \"Hello\" to {name}");         // PROPERTY or FIELD ??
        }

        public void Attack(Warrior enemy)
        {
            enemy.HealthPoints -= Damage;
            System.Console.WriteLine($"{Name} attacks {enemy.name} ({enemy.HealthPoints} health points left) ");
        }

        public void Strike()
        {
            throw new System.NotImplementedException();
        }

        public static void GetAllDefaultInfromation()
        {
            System.Console.WriteLine($"Const constants: \n1.DEFAULT_HEALTHPOINTS={DEFAULT_HEALTHPOINTS}, \n2.DEFAULT_DAMAGE={DEFAULT_DAMAGE}");
        }

        public static void GetAllReadOnlyConstants(Warrior warrior)
        {
            System.Console.WriteLine($"Read-only constant: id={warrior.id}");
        }

    }
}
