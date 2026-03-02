using Clash_of_Classes.Characters;
using Clash_of_Classes.Characters.Magic;
using Clash_of_Classes.Characters.Melee;
using Clash_of_Classes.Enums;
using Clash_of_Classes.Interfaces;

namespace Clash_of_Classes.Factories
{
    public static class CharacterFactory
    {
        public static Character Create(CharacterEnum type, string name, IWeapon weapon) {

            return type switch
            {
                CharacterEnum.Druid => new Druid(name, weapon),
                CharacterEnum.Warrior => new Warrior(name, weapon),
                CharacterEnum.Assasin => new Assasin(name, weapon),
                CharacterEnum.Wizard => new Wizard(name, weapon),
                CharacterEnum.Witch => new Witch(name, weapon),
                CharacterEnum.Knight => new Knight(name, weapon),
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Invalid Character Choice")
            };
        }
    }
}
