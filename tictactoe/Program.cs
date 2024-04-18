namespace tictactoe
{
    internal class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            States game_state = States.Start,
                last_game_state = States.Start;
            Board board = new();
            GameModes gameMode = GameModes.None;
            GameModes winner = new();


            while (game_state is not States.Exit)
            {

                switch (game_state)
                {
                    case States.Start:
                    case States.Menu:
                        game_state = StateHandler.Menu(ref last_game_state);
                        break;
                    case States.Setup:
                        game_state = StateHandler.Setup(ref last_game_state, ref board, ref gameMode);
                        break;
                    case States.Running:
                        game_state = StateHandler.Running(ref last_game_state, ref board, gameMode, ref winner);
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
