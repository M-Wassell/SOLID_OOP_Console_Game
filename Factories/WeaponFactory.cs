using Clash_of_Classes.Enums;
using Clash_of_Classes.Interfaces;
using Clash_of_Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_of_Classes.Factories
{
    public static class WeaponFactory
    {
        public static IWeapon CreateWeapon(WeaponEnum selected) {


            return selected switch
            {
                WeaponEnum.Axe => new Axe(),
                WeaponEnum.Hammer => new Hammer(),
                WeaponEnum.Mace => new Mace(),
                WeaponEnum.Staff => new Staff(),
                WeaponEnum.Sword => new Sword(),
                _ => throw new ArgumentOutOfRangeException(nameof(selected), "Invalid Weapon Selected")
            };
        }
    }
}
