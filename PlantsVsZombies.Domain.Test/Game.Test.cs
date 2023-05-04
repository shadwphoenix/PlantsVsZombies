using System.ComponentModel;
using System.Numerics;

namespace PlantsVsZombies.Domain.Test
{
    public class PlantsVsZombiesTest
    {

        [Fact]
        public void CreateGame_With_GrassType_Should_Fill_GameBoard_With_GrassCells()
        {

            //Arrange
            var sut = new GameEngine();
            //Act
            sut.CreateDayGame(groundType: GroundType.Grass);


            //Assert
            foreach (var cell in sut.DayGame.Cells())
            {
                Assert.Equal(GroundType.Grass, cell.GroundType);
            }
        }

        [Fact]
        public void CreateDayGame_With_WaterType_Should_Fill_GameBoard_With_Correct_Cells()
        {
            //Arrange
            var sut = new GameEngine();

            //Act
            sut.CreateDayGame(groundType: GroundType.Water);

            //Assert
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == 2 || i == 3)
                        Assert.Equal(GroundType.Water, sut.DayGame.Cells()[i, j].GroundType);
                    else
                        Assert.Equal(GroundType.Grass, sut.DayGame.Cells()[i, j].GroundType);
                }
            }
        }

        [Fact]
        public void DayGame_Can_Generate_Random_Number_Of_Suns()
        {
            //Arrange
            var sut = new GameEngine();

            //Act
            sut.CreateDayGame(groundType:GroundType.Grass);
            sut.DayGame.GenerateSun();

            //Assert
            Assert.InRange(sut.DayGame.SunNum, 2, 5);
;
        }


    }
}