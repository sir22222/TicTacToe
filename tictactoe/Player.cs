using System.Data.SqlTypes;

namespace tictactoe
{

    internal static class PLayer
    {
        static int 
                    selected_x = 0, selected_y = 0, 
                    old_selected_x = 0, old_selected_y = 0;
        static bool activate;
        public static bool PLay(CellTypes cell,Board board)
        {
                if (InputHandler.MenuInputs(ref selected_x, ref selected_y, ref activate, 3, 3))
                {
                }
                if (activate) 
                {
                    try
                    {
                        board.PlayCell(selected_x, selected_y, cell);
                    }
                    catch (NotValidMove)
                    {
                        Draw.DrawCell(board.Cell(selected_x, selected_y), (selected_x * 10)+5, (selected_y *10 )+5);
                    }
                    Draw.DrawCell(board.Cell(selected_x,selected_y),(selected_x*10)+5,(selected_y*10)+5,true);
                    activate = false;
                    return true;
                }

                if (selected_x != old_selected_x|| selected_y != old_selected_y)
                {
                    Draw.DrawCell(board.Cell(old_selected_x, old_selected_y), (old_selected_x * 10) + 5, (old_selected_y * 10) + 5);
                    Draw.DrawCell(board.Cell(selected_x,selected_y),(selected_x*10)+5,(selected_y*10)+5,true);
                    old_selected_x = selected_x;
                    old_selected_y = selected_y;
                }

            return false;
        }

    }
}
