﻿namespace _05.Online_Radio_Database
{
    class InvalidArtistNameException : InvalidSongException
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            :base(Message)
        {
        }

        public InvalidArtistNameException(string message) 
            : base(message)
        {
        }
    }
}
