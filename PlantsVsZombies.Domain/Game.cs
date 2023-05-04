
using System.Data;

namespace PlantsVsZombies.Domain
{
    public abstract class Game
    {
        private Cell[,] cells = new Cell[6, 19];

        public int Turn { get; }
        public GroundType GroundType { get; }

        public Cell[,] Cells()
        {
            return cells;
        }

        internal Game(GroundType groundType)
        {
            GroundType = groundType;
            fillBoard();

        }

        private void fillBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == 2)
                        i += 2;
                    cells[i, j] = new Cell(GroundType.Grass);
                }
            }
            fillSpecific(GroundType);
        }

        private void fillSpecific(GroundType groundType)
        {

            for (int i = 2; i < 4; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    cells[i, j] = new Cell(groundType);
                }

            }
        }
    }
}
