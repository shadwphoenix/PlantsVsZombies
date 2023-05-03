namespace PlantsVsZombies.Domain
{
    public class Cell
    {
        internal Cell(GroundType groundType)
        {
            GroundType = groundType;
        }

        public GroundType GroundType { get; }
    }
}