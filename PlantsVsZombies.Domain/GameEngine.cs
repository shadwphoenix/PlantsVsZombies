using System.Collections;

namespace PlantsVsZombies.Domain
{
    public class GameEngine
    {

        private readonly List<Game> games;
        public IEnumerable<Game> Games => games;

        public GameEngine() { 
            games = new List<Game>();
        }

        public void CreateDayGame(GroundType groundType)
        {

            games.Add(new DayGame(groundType));

        }

    };

       

}