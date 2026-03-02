

namespace Clash_of_Classes.Weapons
{
    public class Staff : Weapon
    {
        public Staff()
        {
            Name = "Long and Heavy";
            Damage = 25;
        }
        public override void Use()
        {
            Console.WriteLine($"Swinging {Name} like a pro, dealing {Damage} amount of Damage!");
        }
    }
}
