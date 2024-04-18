namespace tictactoe
{
    internal static class Draw
    {

        static public void DrawSetupLogo()
        {
            Console.Clear();
            Console.WriteLine(
                "  _________       __                \r\n" +
                " /   _____/ _____/  |_ __ ________  \r\n" +
                " \\_____  \\_/ __ \\   __\\  |  \\____ \\ \r\n" +
                " /        \\  ___/|  | |  |  /  |_> >\r\n" +
                "/_______  /\\___  >__| |____/|   __/ \r\n" +
                "        \\/     \\/           |__|    ");
        }
        static public void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "___________.__     ___________           ___________            \r\n" +
                "\\__    ___/|__| ___\\__    ___/____    ___\\__    ___/___   ____  \r\n" +
                "  |    |   |  |/ ___\\|    |  \\__  \\ _/ ___\\|    | /  _ \\_/ __ \\ \r\n" +
                "  |    |   |  \\  \\___|    |   / __ \\\\  \\___|    |(  <_> )  ___/ \r\n" +
                "  |____|   |__|\\___  >____|  (____  /\\___  >____| \\____/ \\___  >\r\n" +
                "                   \\/             \\/     \\/                  \\/ "
                );
        }
        static public void WriteMenuButtons(int start_selected, string[] button_texts, int selected)
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
        static void SetColors(ConsoleColor bg, ConsoleColor fg)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;
        }
    }
}
