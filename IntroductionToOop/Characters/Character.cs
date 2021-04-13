using IntroductionToOop.Characters.Interfaces;
using IntroductionToOop.Enumerations;
using IntroductionToOop.Weapons.Sharp;
using System.Threading;

namespace IntroductionToOop.Characters
{
    public abstract class Character : IDoMath
    {

        // Fields
        public readonly string name;

        private static int idCounter;
        private int damage;
        private Sword weapon;
        private int level;
        private Faction faction;
        private double healthPoints;
        private int numberA;
        private int numberB;

        public Character(string name)
        {
            this.Name = name;
            System.Console.WriteLine("This is the 'Character-BaseClass' Constructor");
        }


        // Properties
        public string Name { get; set; }
        public virtual double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }
        public Sword Weapon { get; set; }
        public int Level
        {
            get { return level; }
            set
            {
                if (value > 0 && value < 100)
                {
                    level = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException(string.Empty, "Invalid level-input; must be between 1-100");
                    // level = 1;
                }
            }
        }
        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            protected set
            {
                idCounter = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }


        public int NumberA { get => this.numberA; set => this.numberA = value; }
        public int NumberB { get => this.numberB; set => this.numberB = value; }


        // Methods
        public virtual void MoveChar(int speed)
        {
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("I'm moving!");
                Thread.Sleep(speed);
            }
        }

        public abstract void AddTwoNumbers();

    }

}
