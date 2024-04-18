namespace tictactoe
{
    internal class Board
    {
        char[,] board = new char[3, 3];
        private bool movesAvalible;
        public bool MovesAvalible { get => movesAvalible; private set => movesAvalible = value; }


        public Board() { }
        public Board(int size)
        {
            board = new char[size, size];
        }

        public void Move(int x, int y, char who)
        {
            if (MoveAvalibe(x, y))
                board[x, y] = who;
            throw new NotValidMove();
        }
        public bool MoveAvalibe(int x, int y) => (board[x, y] == 'X' || board[x, y] == 'O') ? false : true;

        static void PrintBoard(char[,] board)
        {
            Console.Clear();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                    Console.WriteLine($"|{board[i, j]}|");
                Console.WriteLine();
            }
        }

        internal Board CreatBoard()
        {
            throw new NotImplementedException();
        }
    }
}
