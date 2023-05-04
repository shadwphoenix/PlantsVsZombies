using System.Collections;

namespace PlantsVsZombies.Domain
{
    public class GameEngine
    {

        public DayGame? DayGame { get; private set; }

        public void CreateDayGame(GroundType groundType)
        {
            DayGame = new DayGame(groundType);

        }
    }


}