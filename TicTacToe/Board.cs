namespace TicTacToe
{
    public class Board
    {
        public Board()
        {
            Show = Construct(3);
        }

        public Cell[,] Construct(int size)
        {
            return new Cell[,] {
                { new Cell(new Coordinate(0,0)), new Cell(new Coordinate(0,1)), new Cell(new Coordinate(0,2)) },
                { new Cell(new Coordinate(1,0)), new Cell(new Coordinate(1,1)), new Cell(new Coordinate(1,2)) },
                { new Cell(new Coordinate(2,0)), new Cell(new Coordinate(2,1)), new Cell(new Coordinate(2,2)) }
            };
        }

        public Cell[,] Show { get; }

    }
}