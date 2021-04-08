using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop.Characters.Meele

{
    public class Warrior
    {

        private readonly int id;

        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTHPOINTS = 100;

        // Fields
        public readonly string name;
        private int damage;
        private Axe weapon;
        private int level;
        private static int idCounter;

        // Properties
        public string Name { get; set; }
        public int HealthPoints { get; set; }
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
        public Axe Weapon { get; set; }
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
            private set
            {
                idCounter = value;
            }
        }
        public int Id
        {
            get { return id; }
            // set { id = value; }  // readonly field cannot be set from outside, only directly on field in class!
        }



        // Constructor
        public Warrior(string name)
            : this(name, DEFAULT_HEALTHPOINTS, DEFAULT_DAMAGE)
        {
        }


        // Use property of idcounter in constructor due to consistency
        public Warrior(string name, int healthpoints, int damage)
        {
            this.Name = name;
            HealthPoints = healthpoints;
            this.Damage = damage;
            Warrior.IdCounter++;
            this.id = IdCounter;
        }

        public override string ToString()
        {
            return base.ToString() + " - Id: " + id + " / Name: " + this.Name + " (IdCounter: " + IdCounter + ").";
        }




        // PROPERTY or FIELD ??
        public void Greet(string name)
        {
            System.Console.WriteLine($"{this.name} says \"Hello\" to {name}");
            System.Console.WriteLine($"{Name} says \"Hello\" to {name}");
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
