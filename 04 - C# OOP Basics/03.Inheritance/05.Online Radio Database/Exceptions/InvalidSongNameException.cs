namespace _05.Online_Radio_Database
{
    class InvalidSongNameException : InvalidSongException
    {
        private const string Message = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException()
            :base(Message)
        {
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }
    }
}
