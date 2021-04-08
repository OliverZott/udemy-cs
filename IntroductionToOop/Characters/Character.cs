using IntroductionToOop.Enumerations;
using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop.Characters
{
    public class Character
    {
        // Constants
        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTHPOINTS = 100;

        // Fields
        public readonly string name;

        private static int idCounter;
        private int damage;
        private Sword weapon;
        private int level;
        private Faction faction;

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
    }
}
