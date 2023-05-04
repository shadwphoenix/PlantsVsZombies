namespace PlantsVsZombies.Domain
{
    public class DayGame : Game
    {
        internal DayGame(GroundType groundType) : base(groundType)
        {
            SunNum = 2;
        }

        public int SunNum { get; private set; }

        public void GenerateSun()
        {
            var randomSumNum = new Random();

            SunNum += randomSumNum.Next(2,5);
            
        }

    }
}