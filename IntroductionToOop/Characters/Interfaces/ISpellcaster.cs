using IntroductionToOop.Weapons.Sharp;

namespace IntroductionToOop.Characters.Interfaces
{
    public interface ISpellcaster
    {

        int ManaPoints { get; set; }
        Sword Weapon { get; set; }


        void SpellCast();

    }
}
