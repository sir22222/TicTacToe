namespace tictactoe
{

    internal class Board
    {
        CellTypes[,] board = new CellTypes[3, 3];
        public bool MovesAvalible (){
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if(MoveAvalibe(i,j))
                        return true;
            return false;
              }


        public CellTypes Cell(int x, int y) => board[x, y];
        public void PlayCell(int x, int y, CellTypes who)
        {
            if (MoveAvalibe(x, y))
                board[x, y] = who;
            else
                throw new NotValidMove();
        }
        public bool MoveAvalibe(int x, int y) => board[x, y] is not CellTypes.X and not CellTypes.O;

        public bool SomeOneWon(CellTypes cell)
        {
            for (int i = 0; i < 3; i++)
            {
                    if(Cell(i,0)==cell &&
                     Cell(i,0) ==Cell(i,1) && 
                     Cell(i,0) == Cell(i,2))
                     return true;
            }
            for (int i = 0; i < 3; i++)
            {
                    if(Cell(0,i)==cell &&
                     Cell(0,i) ==Cell(1,i) && 
                     Cell(0,i) == Cell(2,i))
                     return true;
            }
            if(
                Cell(0,0) == cell &&
                Cell(0,0) == Cell(1,1)&&
                Cell(0,0)== Cell(2,2)
            )
                return true;
            if(
                Cell(0,2) == cell &&
                Cell(0,2) == Cell(1,1)&&
                Cell(0,2)== Cell(2,0)
                )
                return true;
            return false;

        } 
    } 
}
