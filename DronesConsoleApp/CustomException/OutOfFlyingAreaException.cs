using System;

namespace DronesConsoleApp.CustomException
{
    /// <summary>
    /// Custom exception that represents the drone position is out of flying area.
    /// </summary>
    public class OutOfFlyingAreaException : Exception
    {
        public OutOfFlyingAreaException()
        {
        }

        public OutOfFlyingAreaException(string message)
            : base(message)
        {
        }

        public OutOfFlyingAreaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
