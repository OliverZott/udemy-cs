using IntroductionToOop.Weapons;

namespace IntroductionToOop.Characters.Interfaces
{
    public interface ISpellcaster
    {

        int ManaPoints { get; set; }
        Spell MySpell { get; set; }


        void SpellCast(Character character);

    }
}
