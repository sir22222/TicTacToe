namespace tictactoe
{

    internal class Board
    {
        CellTypes[,] board = new CellTypes[3, 3];
        private bool movesAvalible;
        public bool MovesAvalible { get => movesAvalible; private set => movesAvalible = value; }


        public Board() { }

        public CellTypes Cell(int x, int y) => board[x, y];
        public void PlayCell(int x, int y, CellTypes who)
        {
            if (MoveAvalibe(x, y))
                board[x, y] = who;
            else
                throw new NotValidMove();
        }
        public bool MoveAvalibe(int x, int y) => board[x, y] is not CellTypes.X and not CellTypes.O;



    }
}
