namespace tictactoe
{
    internal class Program
    {
        static Random r = new Random();
        static void Main()
        {
            bool running = true;
            Console.CursorVisible = false;
            States game_state = States.Start;
            while (running)
            {

                switch (game_state)
                {
                    case States.Start:
                    case States.Menu:
                        game_state = StateHandler.Menu(ref running, game_state);
                        break;
                    case States.Setup:
                        game_state = StateHandler.Setup(ref running,game_state);
                        break;
                    case States.Running:
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
