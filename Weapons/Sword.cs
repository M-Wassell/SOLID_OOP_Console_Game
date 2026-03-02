

namespace Clash_of_Classes.Weapons
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Name = "Spiker";
            Damage = 25;
        }
        public override void Use()
        {
            Console.WriteLine($"Swinging {Name} like a pro, dealing {Damage} amount of Damage!");
        }
    }
}
