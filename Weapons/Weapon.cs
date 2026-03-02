using Clash_of_Classes.Enums;
using Clash_of_Classes.Interfaces;

namespace Clash_of_Classes.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public string? Name { get; protected set; }
        public int Damage { get; protected set; }

        public WeaponEnum Type { get; }

        public Weapon(){
        }

        public abstract void Use();
        
    }
}
