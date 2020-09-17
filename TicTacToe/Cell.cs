namespace TicTacToe
{
    public class Cell
    {
        public Cell(Coordinate coordinate)
        {
            Location = coordinate;
            IsEmpty = true;
            Value = ".";
        }
        public bool IsEmpty {get; set;} 
        public string Value {get; set;}
        public Coordinate Location {get;}
    }
}