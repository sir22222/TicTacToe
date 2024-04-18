namespace tictactoe
{
    internal class Program
    {
        static void Main()
        {
            bool running = true;
            Console.CursorVisible = false;
            States game_state = States.Start,
                last_game_state = States.Start;
            Board board = new();
            Users[] users = [];
            while (running)
            {

                switch (game_state)
                {
                    case States.Start:
                    case States.Menu:
                        game_state = StateHandler.Menu(ref running, ref last_game_state);
                        break;
                    case States.Setup:
                        game_state = StateHandler.Setup(ref running, ref last_game_state, ref board, out users);
                        break;
                    case States.Running:
                        game_state = StateHandler.Running(ref running, ref last_game_state, ref board, users);
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
