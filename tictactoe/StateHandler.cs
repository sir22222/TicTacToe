namespace tictactoe
{
    static internal class StateHandler
    {
        static int selected, old_selected;
        static bool activate;
        static int selected_x, selected_y = 0, old_selected_x, old_selected_y;
        static public States Menu(ref States last)
        {

            activate = false;
            int main_text_height = 6;
            string[] buttons = ["Start Game", "Quit"];
            /*
             *  Seting up menu
             */
            if (last is not States.Menu)
            {
                selected = 0;
                old_selected = 0;
                Draw.DrawMenuLogo();
                Draw.DrawMenuButtons(main_text_height, buttons, selected);
            }
            /*
             * checking for inputs and changeing based on that
             */
            else
            {
                old_selected = selected;
                selected = InputHandler.MenuInputs(selected, ref activate, 2);
                if (activate)
                    return selected switch
                    {
                        0 => States.Setup,
                        1 => States.Exit,
                        _ => throw new NotImplementedException(),
                    };
                if (selected != old_selected)
                {
                    Draw.DrawMenuButtons(main_text_height, buttons, selected);
                }
            }

            last = States.Menu;
            return States.Menu;


        }




        static public States Setup(ref States last, ref Board board, ref GameModes gameMode)
        {
            int main_text_height = 6;



            string[] buttons = [
                "Player VS Player",
                "Player VS Com" ,
                "Com VS Com",
                "Back To Menu"];

            if (last is not States.Setup)
            {
                selected = 0;
                old_selected = 0;
                activate = false;
                board = new Board();
                Draw.DrawSetupLogo();
                Draw.DrawMenuButtons(main_text_height, buttons, selected);
            }
            else
            {
                old_selected = selected;
                selected = InputHandler.MenuInputs(selected, ref activate, 4);
                if (activate)
                    switch (selected)
                    {
                        case 0:
                            gameMode = GameModes.PvP;
                            return States.Running;
                        case 1:
                            gameMode = GameModes.PvC;
                            return States.Running;
                        case 2:
                            gameMode = GameModes.CvC;
                            return States.Running;
                        case 3:
                            return States.Menu;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                if (selected != old_selected)
                {
                    Draw.DrawMenuButtons(main_text_height, buttons, selected);
                }
            }
            last = States.Setup;
            return States.Setup;
        }

        static public States Running(ref States last, ref Board board, GameModes gameMode, ref GameModes winner)
        {
            if (last is not States.Running)
            {
                selected_x = 0; selected_y = 0;
                old_selected_x = 0; old_selected_y = 0;
                activate = false;
                Console.Clear();
                Draw.DrawGrid();
                Draw.DrawCell(board.Cell(0, 0), 5, 5);
            }
            else
            {
                if (InputHandler.MenuInputs(ref selected_x, ref selected_y, ref activate, 3, 3))
                {
                    last = States.Running;
                    return States.Running;
                }
                if (activate) 
                {
                    try
                    {
                        board.PlayCell(selected_x, selected_y, CellTypes.X);
                    }
                    catch (NotValidMove)
                    {
                        Draw.DrawCell(board.Cell(selected_x, selected_y), (selected_x * 10)+5, (selected_y *10 )+5);
                    }
                    activate = false;
                }

                if (selected_x != old_selected_x|| selected_y != old_selected_y)
                {
                    Draw.DrawCell(board.Cell(selected_x,selected_y),(selected_x*10)+5,(selected_y*10)+5);
                    Draw.DrawCell(board.Cell(old_selected_x, old_selected_y), (old_selected_x * 10) + 5, (old_selected_y * 10) + 5);
                }

            }

            last = States.Running;
            return States.Running;
        }

    }
}
