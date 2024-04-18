namespace tictactoe
{

    internal class Board
    {
        char[,] board = new char[3, 3];
        private bool movesAvalible;
        public bool MovesAvalible { get => movesAvalible; private set => movesAvalible = value; }


        public Board() { }

        public char Cell(int x, int y) => board[x, y];
        public void Move(int x, int y, char who)
        {
            if (MoveAvalibe(x, y))
                board[x, y] = who;
            throw new NotValidMove();
        }
        public bool MoveAvalibe(int x, int y) => board[x, y] is not 'X' and not 'O';



    }
}
