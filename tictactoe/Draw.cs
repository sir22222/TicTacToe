namespace tictactoe
{
    internal static class Draw
    {

        static public void DrawSetupLogo()
        {
            Console.Clear();
            SetColors(ConsoleColor.Red);
            Console.WriteLine(
                "  _________       __                \r\n" +
                " /   _____/ _____/  |_ __ ________  \r\n" +
                " \\_____  \\_/ __ \\   __\\  |  \\____ \\ \r\n" +
                " /        \\  ___/|  | |  |  /  |_> >\r\n" +
                "/_______  /\\___  >__| |____/|   __/ \r\n" +
                "        \\/     \\/           |__|    ");
            Console.ResetColor();
        }
        static public void DrawMenuLogo()
        {
            Console.Clear();
            SetColors(ConsoleColor.Cyan);
            Console.WriteLine(
                "___________.__     ___________           ___________            \r\n" +
                "\\__    ___/|__| ___\\__    ___/____    ___\\__    ___/___   ____  \r\n" +
                "  |    |   |  |/ ___\\|    |  \\__  \\ _/ ___\\|    | /  _ \\_/ __ \\ \r\n" +
                "  |    |   |  \\  \\___|    |   / __ \\\\  \\___|    |(  <_> )  ___/ \r\n" +
                "  |____|   |__|\\___  >____|  (____  /\\___  >____| \\____/ \\___  >\r\n" +
                "                   \\/             \\/     \\/                  \\/ "
                );
            Console.ResetColor();
        }

        static public void DrawGameScreen()
        {

        }

        static public void DrawMenuButtons(int start_selected, string[] button_texts, int selected)
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
        static void SetColors(ConsoleColor fg)
        {
            Console.ForegroundColor = fg;
        }
        static void SetColors(ConsoleColor bg, ConsoleColor fg)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;
        }
        static public void DrawBoard(Board board)
        {
            Console.Clear();
        }

        static public void DrawGrid(int verical_offset) 
        {
            int v_pos = 0, h_pos = 0;
            DrawCell(CellTypes.top_left_corner,v_pos+verical_offset,h_pos+=5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.T_intersection_top, v_pos + verical_offset,h_pos += 5);
            DrawCell(CellTypes.horizontal_wall,v_pos +verical_offset,h_pos += 5);
            DrawCell(CellTypes.T_intersection_top, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.top_right_corner, v_pos + verical_offset, h_pos+=5);
            
            v_pos += 5;
            h_pos = 0;

            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);

            v_pos += 5;
            h_pos = 0;

            DrawCell(CellTypes.T_intersection_left, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.inside_intersection, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.inside_intersection, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.T_intersection_right, v_pos + verical_offset, h_pos += 5);

            v_pos += 5;
            h_pos = 0;

            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);

            v_pos += 5;
            h_pos = 0;

            DrawCell(CellTypes.T_intersection_left, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.inside_intersection, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.inside_intersection, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.T_intersection_right, v_pos + verical_offset, h_pos += 5);

            v_pos += 5;
            h_pos = 0;

            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);
            DrawCell(CellTypes.vertical_wall, v_pos + verical_offset, h_pos += 10);

            v_pos += 5;
            h_pos = 0;
            DrawCell(CellTypes.bottom_left_corner, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.T_intersection_bottom, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.T_intersection_bottom, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.horizontal_wall, v_pos + verical_offset, h_pos += 5);
            DrawCell(CellTypes.bottom_right_corner, v_pos + verical_offset, h_pos += 5);
        }

        static public void DrawCell(CellTypes c, int start_x_pos, int start_y_pos)
        {
            switch (c)
            {
                #region played moves
                case CellTypes.X:
                    Console.SetCursorPosition(start_y_pos, start_x_pos);
                    Console.Write("x   x");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" x x ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("  x  ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" x x ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("x   x");
                    break;
                case CellTypes.O:
                    Console.SetCursorPosition(start_y_pos, start_x_pos);
                    Console.Write("  x  ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" x x ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("x   x");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" x x ");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("  x  ");
                    break;
                #endregion
                #region walls
                case CellTypes.vertical_wall:
                    for (int i = 0; i < 5; i++)
                    {

                        Console.SetCursorPosition(start_y_pos, start_x_pos++);
                        Console.Write(" |||");
                    }
                    break;
                case CellTypes.horizontal_wall:
                    ++start_x_pos;
                    for (int i = 0; i < 2; i++)
                    {
                        Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                        Console.Write("-----");
                    }
                    break;
                #endregion
                #region corners
                case CellTypes.top_left_corner:
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" +++-");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" +++-");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" ||| ");
                    break;
                case CellTypes.bottom_left_corner:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" +++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" +++-");
                    break;
                case CellTypes.top_right_corner:
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("-+++");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("-+++");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" ||| ");
                    break;
                case CellTypes.bottom_right_corner:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++");
                    break;
                #endregion
                #region intersections
                case CellTypes.T_intersection_top:
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("-+++-");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write("-+++-");
                    Console.SetCursorPosition(start_y_pos, ++start_x_pos);
                    Console.Write(" ||| ");
                    break;
                case CellTypes.T_intersection_bottom:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++-");
                    break;
                case CellTypes.T_intersection_left:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" +++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" +++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos);
                    Console.Write(" ||| ");
                    break;
                case CellTypes.T_intersection_right:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++");
                    Console.SetCursorPosition(start_y_pos, start_x_pos);
                    Console.Write(" ||| ");
                    break;
                case CellTypes.inside_intersection:
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write(" ||| ");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos++);
                    Console.Write("-+++-");
                    Console.SetCursorPosition(start_y_pos, start_x_pos);
                    Console.Write(" ||| ");
                    break;
                    #endregion
            }

        }
    }
}
