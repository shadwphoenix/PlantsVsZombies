namespace PlantsVsZombies.Domain.Creature
{
    internal class Plant
    {
        internal int Timer { get; set; }
        internal int ShootingRate { get; }
        internal Projectile Projectile { get; }

        public Plant(int timer, int shootingRate, Projectile projectile)
        {
            Timer = timer;
            ShootingRate = shootingRate;
            Projectile = projectile;
        }

        public void ResetTimer() { Timer = 0; }

        // TODO: what is generateProjectile?
    }
}
