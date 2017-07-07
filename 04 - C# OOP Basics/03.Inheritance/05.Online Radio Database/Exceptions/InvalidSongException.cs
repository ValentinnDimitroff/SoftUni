namespace _05.Online_Radio_Database
{
    using System;
    public class InvalidSongException : ArgumentException
    {
        private const string Message = "Invalid song.";
        
        public InvalidSongException()
            :base(Message)
        {
        }

        public InvalidSongException(string message)
            : base(message)
        {
        }
    }
}
