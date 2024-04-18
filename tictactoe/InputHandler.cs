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


        public static int MenuInputs(int x_position, int y_position, ref bool activate, int height,int width)
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

    }
}
