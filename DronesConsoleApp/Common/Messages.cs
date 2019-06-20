using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Common
{
    /// <summary>
    /// Class to register messages.
    /// </summary>
    class Messages
    {
        public const string flyingArea = "Flying Area: ";
        public const string flyingAreaRegexPattern = @"^\d+ \d+$";
        public const string numberDrones = "Number of drones: ";
        public const string numberDronesRegexPattern = @"^\d+$";
        public const string dronStartPosition = "Dron {0} Start Position: ";
        public const string dronStartPositionRegexPattern = @"^\d+ \d+ [NSEW]$";
        public const string dronMovements = "Dron {0} Movements: ";
        public const string dronMovementsRegexPattern = @"^[LRM]+$";
        public const string dronPosition = "Dron {0} position: {1}  {2}";
        public const string incorrectParameter = "Incorrect parameter format.";
        public const string dronInitOutsideFlyingArea = "Dron {0} has been deleted because it is outside flying area.";

        public const string generalExceptionMessage = "Error executing application. Message: {0} - Stack Trace: {1}";
        public const string outOfFlyingAreaMessage = "Unable to move the dron. Target position is out of flying area.";
    }
}
