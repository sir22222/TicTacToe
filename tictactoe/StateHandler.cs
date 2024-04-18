namespace tictactoe
{
    static internal class StateHandler
    {
        static int selected;
        static int old_selected;
        static bool activate;
        static public States Menu(ref bool run, ref States last)
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
                Draw.DrawMenu();
                Draw.WriteMenuButtons(main_text_height, buttons, selected);
            }
            /*
             * checking for inputs and changeing based on that
             */
            else
            {
                old_selected = selected;
                selected = InputHandler.MenuInputs(selected, ref activate, ref run, 2);
                if (activate)
                    switch (selected)
                    {
                        case 0:
                            return States.Setup;
                        case 1:
                            run = false;
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                if (selected != old_selected)
                {
                    Draw.WriteMenuButtons(main_text_height, buttons, selected);
                }
            }

            last = States.Menu;
            return States.Menu;


        }




        static public States Setup(ref bool runnig, ref States last, ref Board board, out Users[] users)
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
                Draw.WriteMenuButtons(main_text_height, buttons, selected);
            }
            else
            {
                old_selected = selected;
                selected = InputHandler.MenuInputs(selected, ref activate, ref runnig, 4);
                if (activate)
                    switch (selected)
                    {
                        case 0:
                            users = [Users.Player, Users.Player];
                            return States.Running;
                        case 1:
                            users = [Users.Player, Users.COM];
                            return States.Running;
                        case 2:
                            users = [Users.COM, Users.COM];
                            return States.Running;
                        case 3:
                            users = null;
                            return States.Menu;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                if (selected != old_selected)
                {
                    Draw.WriteMenuButtons(main_text_height, buttons, selected);
                }
            }
            users = null;
            last = States.Setup;
            return States.Setup;
        }

        static public States Running(ref bool running, ref States last, ref Board board, Users[] users)
        {

            last = States.Running;
            return States.Running;
        }

    }
}
