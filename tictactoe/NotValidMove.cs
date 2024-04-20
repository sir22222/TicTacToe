using System.Runtime.Serialization;

namespace tictactoe
{
    [Serializable]
    internal class NotValidMove : Exception
    {
        public NotValidMove()
        {
        }

        public NotValidMove(string? message) : base(message)
        {
        }

        public NotValidMove(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}