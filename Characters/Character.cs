using Clash_of_Classes.Interfaces;

namespace Clash_of_Classes.Characters
{
    public abstract class Character
    {
        public int HealthPoints { get; protected set; }
        public int Level { get; protected set; }
        public string? Name { get; private set; }
        public IWeapon? Weapon { get; set; }

        protected Character(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public abstract void Attack();
    }
}
