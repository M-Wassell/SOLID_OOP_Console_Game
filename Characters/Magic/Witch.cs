using Clash_of_Classes.Interfaces;


namespace Clash_of_Classes.Characters.Magic
{
    public class Witch : Character
    {
        public Witch(string name, IWeapon weapon) : base(name, weapon)
        {
            HealthPoints = 100;
            Level = 1;
        }

        public override void Attack()
        {
            Weapon.Use();
        }
    }
}
