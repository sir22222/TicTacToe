namespace tictactoe
{
    static internal class InputHandler
    {
        public static int MenuInputs(int position, ref bool activate, int button_count)
        {
            switch (Console.ReadKey(false).Key)
            {
                case ConsoleKey.Enter:
                case ConsoleKey.Spacebar:
                    activate = true;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.DownArrow:
                    return Math.Abs((position + 1) % button_count);

                case ConsoleKey.RightArrow:
                case ConsoleKey.UpArrow:
                    return Math.Abs((position - 1 + button_count) % button_count);
                case ConsoleKey.Escape:
                case ConsoleKey.Q:
                    return button_count - 1;
                default:
                    break;
            }
            return position;
        }


        public static bool MenuInputs(ref int x_pos,ref int y_pos, ref bool activate, int height,int width)
        {
            switch (Console.ReadKey(false).Key)
            {
                case ConsoleKey.Enter:
                case ConsoleKey.Spacebar:
                    activate = true;
                    break;
                case ConsoleKey.LeftArrow:
                    y_pos = Math.Abs((y_pos - 1 + width) % width);
                    break;
                case ConsoleKey.RightArrow:
                    y_pos=Math.Abs((y_pos + 1) % width);
                    break;


                case ConsoleKey.DownArrow:
                    x_pos= Math.Abs((x_pos+ 1) % height);
                    break;
                case ConsoleKey.UpArrow:
                    x_pos = Math.Abs((x_pos - 1 + height) % height);
                    break;
                case ConsoleKey.Escape:
                case ConsoleKey.Q:;
                    return true;
                default:
                    break;
            }
            return false;
        }

    }
}
