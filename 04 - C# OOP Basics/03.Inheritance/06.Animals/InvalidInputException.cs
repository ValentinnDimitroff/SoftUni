namespace Animals
{
    using System;
    public class InvalidInputException : ArgumentException
    {
        private const string Message = "Invalid input!";

        public InvalidInputException():base(Message)
        {
        }
    }
}
