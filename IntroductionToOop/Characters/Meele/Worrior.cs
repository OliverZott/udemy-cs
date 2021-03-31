using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop.Characters.Meele

{
    class Worrior
    {
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
                return damage;
            }
            set
            {
                damage = value;
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


        // Constructor
        public Worrior(string name, int healthpoints, int damage)
        {
            this.name = name;
            HealthPoints = healthpoints;
            this.Damage = damage;
        }


        public void Greet(string name)
        {
            System.Console.WriteLine($"{Name} says \"Hello\" to {name}");
        }

        public void Attack(Worrior enemy)
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
