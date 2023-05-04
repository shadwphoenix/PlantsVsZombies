namespace PlantsVsZombies.Domain
{
    internal class Creature
    {
        internal long id;
        internal String nameOfCreature;

        internal int Row { get; }
        internal int Col { get; }
        internal long Health { get; private set; }
        internal long Speed { get; private set; }
        internal long Cost { get; private set; }
        internal GroundType Habitant { get; private set; }

        public Creature(long id, String nameOfCreature, int Row, int Col, long Health, long Speed, long Cost, GroundType Habitant)
        {
            this.id = id;
            this.nameOfCreature = nameOfCreature;
            this.Row = Row;
            this.Col = Col;
            this.Health = Health;
            this.Speed = Speed;
            this.Cost = Cost;
            this.Habitant = Habitant;
        }

        public void reduceHeath(int amountToReduce)
        {
            Health -= amountToReduce;
        }
    }
}
