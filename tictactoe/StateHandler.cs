namespace tictactoe
{
    static internal class StateHandler
    {
        static int cursor_pos;
        static int old_cursor_pos;
        static public States Menu(ref bool run, States last)
        {
            bool activate = false;
            /*
             *  Seting up menu
             */
            if (last is not States.Menu)
            {
                cursor_pos = 0;
                old_cursor_pos = 0;

                Console.SetCursorPosition(0, 0);
                //Slant font
                Console.WriteLine(
                    "\t    __  ____           _____                                  \r\n" +
                    "\t   /  |/  (_)___  ___ / ___/      _____  ___  ____  ___  _____\r\n" +
                    "\t  / /|_/ / / __ \\/ _ \\\\__ \\ | /| / / _ \\/ _ \\/ __ \\/ _ \\/ ___/\r\n" +
                    "\t / /  / / / / / /  __/__/ / |/ |/ /  __/  __/ /_/ /  __/ /    \r\n" +
                    "\t/_/  /_/_/_/ /_/\\___/____/|__/|__/\\___/\\___/ .___/\\___/_/     \r\n" +
                    "\t                                          /_/                 "
                    );

                WriteMenuButtons(cursor_pos);


            }
            /*
             * checking for inputs and changeing based on that
             */
            else
            {
                old_cursor_pos = cursor_pos;
                //Handelig inputs
                cursor_pos = InputHandler.MenuInputs(cursor_pos, ref activate, ref run);
                if (activate && cursor_pos == 0)
                {
                    return States.Setup;
                }
                else if (activate && cursor_pos == 1)
                    run = false;
                if (cursor_pos != old_cursor_pos)
                {
                    WriteMenuButtons(cursor_pos);
                    old_cursor_pos = cursor_pos;
                }
            }

            return States.Menu;

            static void WriteMenuButtons(int cursor_pos)
            {
                //10th line in console
                if (cursor_pos == 0)
                    SetColors(ConsoleColor.White, ConsoleColor.Black);
                Console.SetCursorPosition(2, 7);
                Console.Write("Start Game");

                Console.ResetColor();

                if (cursor_pos == 1)
                    SetColors(ConsoleColor.White, ConsoleColor.Black);
                Console.SetCursorPosition(2, 9);
                //12th line in console
                Console.Write("Quit");

                Console.ResetColor();
            }
        }


        static void SetColors(ConsoleColor bg, ConsoleColor fg)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;
        }

        static public States Setup(ref bool runnig, States last)
        {
            if (last is not States.Setup)
            {
                Board board = new Board();
            }
            else 
            {
            
            }

            return States.Running;
        }

        /*
      static public States Running(Board board, Users[] users, ref States last)
        {
            do
            {

            } while (board.MovesAvalible);
            return States.Menu;


        }
      */
    }
}
