using IntroductionToOop.Characters.Interfaces;
using IntroductionToOop.Enumerations;

namespace IntroductionToOop.Characters.Meele

{
    public class Warrior : Character, IDoMath
    {

        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_SPEED = 1000;

        public readonly int id;
        private int numberA;
        private int numberB;


        // Constructor
        public Warrior(string name)
            : this(name, DEFAULT_HEALTHPOINTS, DEFAULT_DAMAGE, Faction.GoodGuy)
        {
            System.Console.WriteLine("This is the 'Warrior-ChildClass' ConstructorlLevel-2");
        }

        // uses base class 'Character'
        public Warrior(string name, int healthpoints, int damage, Faction faction)
            : base(name)
        {
            HealthPoints = healthpoints;
            this.Damage = damage;
            base.Faction = faction;
            Warrior.IdCounter++;
            this.id = IdCounter;

            System.Console.WriteLine("This is the 'Warrior-ChildClass' ConstructorlLevel-1");

            switch (faction)
            {
                case Faction.GoodGuy:
                    Level = 1;
                    break;
                case Faction.BadGuy:
                    base.Level = 2;
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
        public override double HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    base.HealthPoints = value;
                }
            }
        }

        public int NumberA { get => this.numberA; set => this.numberA = value; }
        public int NumberB { get => this.numberB; set => this.numberB = value; }


        public override string ToString()
        {
            return base.ToString() + " - Id: " + id + " (IdCounter: " + IdCounter + ")." +
                "\nName: " + this.Name +
                "\nHealthPoints" + this.HealthPoints;
        }


        public void Greet(string name)
        {
            // System.Console.WriteLine($"{this.name} says \"Hello\" to {name}");
            System.Console.WriteLine($"{this.Name} says \"Hello\" to {name}");         // PROPERTY or FIELD ??
        }

        public override void MoveChar(int speed = DEFAULT_SPEED)
        {
            System.Console.WriteLine($"Hello, it's {this.Name}");
            base.MoveChar(speed);
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

        public void AddTwoNumbers()
        {
            System.Console.WriteLine(this.numberA + this.numberB);
        }
    }
}
