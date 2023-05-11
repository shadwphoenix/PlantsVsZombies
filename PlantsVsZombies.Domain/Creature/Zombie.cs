namespace PlantsVsZombies.Domain.Creature
{
    internal class Zombie
    {
        internal int Shield { get;  }
        internal AbilityOfZombie Ability { get; }

        public Zombie(int shield, AbilityOfZombie ability)
        {
            Shield = shield;
            Ability = ability;
        }

        // TODO: what is attack()?
    }
}
