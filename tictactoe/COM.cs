namespace tictactoe
{
    internal static class COM
    {
        static Random r = new();
        public static void Play(CellTypes cell,Board board)
        {
            Thread.Sleep(r.Next(2,20));
            int x,y;
            do
            {
                x =r.Next(0,3);
                y =r.Next(0,3);
            } while (!board.MoveAvalibe(x,y));
            board.PlayCell(x,y,cell);
            Draw.DrawCell(cell,(x*10)+5,(y*10)+5);
        }
    
    }
}
