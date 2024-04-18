﻿namespace tictactoe
{
    static internal class InputHandler
    {
        public static int MenuInputs(int position, ref bool activate, ref bool running)
        {
            switch (Console.ReadKey(false).Key)
            {
                case ConsoleKey.Enter:
                case ConsoleKey.Spacebar:
                    activate = true;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.DownArrow:
                    return Math.Abs((position - 1) % 2);

                case ConsoleKey.RightArrow:
                case ConsoleKey.UpArrow:
                    return Math.Abs((position + 1) % 2);

                case ConsoleKey.Escape:
                case ConsoleKey.Q:
                    running = false;
                    break;
                default:
                    break;
            }
            return position;

        }

    }
}