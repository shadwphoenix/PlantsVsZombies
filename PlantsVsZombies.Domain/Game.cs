
namespace PlantsVsZombies.Domain
{
    public abstract class Game
    {
        private Cell[,] cells = new Cell[6, 19];

        internal Game(GroundType groundType) 
        {
            GroundType = groundType;
            if (GroundType == GroundType.Grass)
            {
                fillGrassBoard();
            }

            else
            {
                fillWaterBoard();
            }
            
        }
        private void fillWaterBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == 2 || i == 3)
                        cells[i, j] = new Cell(GroundType.Water);
                    else
                        cells[i, j] = new Cell(GroundType.Grass);
                }
            }
        }

        private void fillGrassBoard()
        {
            for(int i = 0;i<6;i++) 
            { 
                for(int j = 0; j < 19; j++)
                {
                    cells[i, j] = new Cell(GroundType.Grass);
                }
            }
        }

        public int Turn { get;}
        public GroundType GroundType { get;}

        public Cell[,] Cells()
        {
            return cells;
        }

    }
}
