using DronesConsoleApp.Business;
using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Common
{
    /// <summary>
    /// Class with miscelaneous utilities
    /// </summary>
    static class Utils
    {        
        /// <summary>
        /// Method that checks if a number is between other two numbers. Inclusive.
        /// </summary>
        /// <param name="value">Number to check.</param>
        /// <param name="lowerValue">Lower value.</param>
        /// <param name="upperValue">Upper value.</param>
        /// <returns></returns>
        public static bool Between(int value, int lowerValue, int upperValue)
        {
            return (value >= lowerValue && value <= upperValue);
        }        

        /// <summary>
        /// Method to map direction string to Direction enum.
        /// </summary>
        /// <param name="direction">direction: N, S, E, W</param>
        /// <returns></returns>
        public static Direction DirectionMapper(string direction)
        {
            switch (direction)
            {
                case "N":
                    return Direction.N;                    
                case "S":
                    return Direction.S;
                case "E":
                    return Direction.E;
                case "W":
                    return Direction.W;
                default:
                    throw new Exception();

            }
        }

        /// <summary>
        /// Method to map movement string to Movement enum.
        /// </summary>
        /// <param name="movement">movement: L, R, M</param>
        /// <returns></returns>
        public static Movement MovementMapper(char movement)
        {
            switch (movement)
            {
                case 'L':
                    return Movement.L;
                case 'R':
                    return Movement.R;
                case 'M':
                    return Movement.M;                
                default:
                    throw new Exception();

            }
        }
    }
}
