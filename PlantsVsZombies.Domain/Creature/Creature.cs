namespace PlantsVsZombies.Domain.Creature
{
    internal abstract class Creature
    {
        internal long id;
        internal string nameOfCreature;

        internal int Row { get; }
        internal int Col { get; }
        internal long Health { get; private set; }
        internal long Speed { get; private set; }
        internal long Cost { get; private set; }
        internal GroundType Habitant { get; private set; }

        public Creature(long id, string nameOfCreature, int row, int col, long health, long speed, long cost, GroundType habitant)
        {
            this.id = id;
            this.nameOfCreature = nameOfCreature;
            Row = row;
            Col = col;
            Health = health;
            Speed = speed;
            Cost = cost;
            Habitant = habitant;
        }

        public void reduceHeath(int amountToReduce)
        {
            Health -= amountToReduce;
        }

        public void setHealthToZero()
        {
            Health = 0;
        }
    }
}
