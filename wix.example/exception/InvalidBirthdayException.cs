using System;

namespace wix.example.exception
{
    public class InvalidBirthdayException : Exception
    {
        public InvalidBirthdayException(string message) : base(message){}
    }
}