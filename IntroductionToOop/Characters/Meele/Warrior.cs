using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop.Characters.Meele

{
    public class Warrior
    {

        private static int idCounter;

        // Fields
        public readonly string name;
        private int damage;
        private Axe weapon;
        private int level;

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


        // Constructor
        public Warrior(string name)
            : this(name, 100, 10)
        {
        }


        // Use property of idcounter in constructor due to consistency 
        public Warrior(string name, int healthpoints, int damage)
        {
            this.Name = name;
            HealthPoints = healthpoints;
            this.Damage = damage;
            Warrior.IdCounter++;
        }

        public override string ToString()
        {
            return base.ToString() + " - Id: " + idCounter + " / Name: " + this.Name + ".";
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


    }
}
