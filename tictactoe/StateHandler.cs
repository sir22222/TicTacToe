using System.Runtime.InteropServices;

namespace tictactoe
{
    static internal class StateHandler
    {
        static int selected;
        static int old_selected;
        static bool activate;
        static public States Menu(ref bool run,ref States last)
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
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                //Slant font
                Console.WriteLine(
                    "___________.__     ___________           ___________            \r\n" +
                    "\\__    ___/|__| ___\\__    ___/____    ___\\__    ___/___   ____  \r\n" +
                    "  |    |   |  |/ ___\\|    |  \\__  \\ _/ ___\\|    | /  _ \\_/ __ \\ \r\n" +
                    "  |    |   |  \\  \\___|    |   / __ \\\\  \\___|    |(  <_> )  ___/ \r\n" +
                    "  |____|   |__|\\___  >____|  (____  /\\___  >____| \\____/ \\___  >\r\n" +
                    "                   \\/             \\/     \\/                  \\/ "
                    );

                WriteMenuButtons(main_text_height + 2, buttons, selected);

            }
            /*
             * checking for inputs and changeing based on that
             */
            else
            {
                old_selected = selected;
                selected = InputHandler.MenuInputs(selected, ref activate, ref run, 2);
                if (activate && selected == 0)
                {
                    return States.Setup;
                }
                else if (activate && selected == 1)
                    run = false;
                if (selected != old_selected)
                {
                    WriteMenuButtons(main_text_height + 2, buttons, selected);
                }
            }

            last = States.Menu;
            return States.Menu;


        }


        static void SetColors(ConsoleColor bg, ConsoleColor fg)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;
        }

        static public States Setup(ref bool runnig,ref States last, ref Board board, out Users[] users)
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

                Console.Clear();
                Console.WriteLine(
                    "  _________       __                \r\n" +
                    " /   _____/ _____/  |_ __ ________  \r\n" +
                    " \\_____  \\_/ __ \\   __\\  |  \\____ \\ \r\n" +
                    " /        \\  ___/|  | |  |  /  |_> >\r\n" +
                    "/_______  /\\___  >__| |____/|   __/ \r\n" +
                    "        \\/     \\/           |__|    ");
                WriteMenuButtons(main_text_height, buttons, selected);

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
                    WriteMenuButtons(main_text_height, buttons, selected);
                }
            }
            users = null;
            last = States.Setup;
            return States.Setup;
        }

        static public States Running(ref bool running,ref States last, ref Board board, Users[] users)
        {

            last = States.Running;
            return States.Running;
        }
        static void WriteMenuButtons(int start_selected, string[] button_texts, int selected)
        {
            for (int i = 0; i < button_texts.Length; i++)
            {
                if (i == selected)
                    SetColors(ConsoleColor.White, ConsoleColor.Black);
                Console.SetCursorPosition(2, start_selected + (2 * (i + 1)));
                Console.WriteLine(button_texts[i]);
                Console.ResetColor();

            }
        }
    }
}
