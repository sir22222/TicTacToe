namespace tictactoe
{
    static internal class StateHandler
    {
        static int selected, old_selected;
        static bool activate;
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

        static public States Running(ref States last, ref Board board, GameModes gameMode, ref CellTypes winner)
        {
            if (last is not States.Running)
            {

                activate = false;
                winner = CellTypes.None;
                Console.Clear();
                Draw.DrawGrid();
                Draw.DrawCell(board.Cell(0, 0), 5, 5,true);
                last = States.Running;
            }
            else
            {
                switch (gameMode)
                {
                    case GameModes.PvP:
                        while(!PLayer.PLay(CellTypes.X,board));
                        if(board.SomeOneWon(CellTypes.X) )
                        {
                            winner = CellTypes.X;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;
                        while(!PLayer.PLay(CellTypes.O,board));
                        if(board.SomeOneWon(CellTypes.O) )
                        {
                            winner = CellTypes.O;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;

                        break;
                    case GameModes.PvC:
                        while(!PLayer.PLay(CellTypes.X,board));
                        if(board.SomeOneWon(CellTypes.X) )
                        {
                            winner = CellTypes.X;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;
                        COM.Play(CellTypes.O,board);
                        if(board.SomeOneWon(CellTypes.O) )
                        {
                            winner = CellTypes.O;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;
                        break;
                    case GameModes.CvC:
                        COM.Play(CellTypes.X,board);
                        if(board.SomeOneWon(CellTypes.X) )
                        {
                            winner = CellTypes.X;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;COM.Play(CellTypes.O,board);
                        if(board.SomeOneWon(CellTypes.O) )
                        {
                            winner = CellTypes.O;
                            return States.End;
                        }
                        if(!board.MovesAvalible())return States.End;
                        break;

                }

            }

            return States.Running;
        }

    }
}
