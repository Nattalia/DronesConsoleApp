using DronesConsoleApp.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DronesConsoleApp
{
    /// <summary>
    /// Class to get input parameters and verify if they are in correct format.
    /// </summary>
    class InputHelper
    {
        /// <summary>
        /// Method to get input parameter from console.
        /// </summary>
        /// <param name="message">Message shown to the user to enter input.</param>
        /// <param name="format">Regex pattern </param>
        /// <returns></returns>
        public static string GetValidInputParameter(string message, string format)
        {
            string parameter;
            bool validParameter = true;
            
            do
            {
                Console.WriteLine(message);
                parameter = Console.ReadLine();
                validParameter = ValidateParameter(parameter, format);

                if (!validParameter)
                    Console.WriteLine(Messages.incorrectParameter);

            } while (!validParameter);

            return parameter;
        }

        /// <summary>
        /// Method to validate input parameter.
        /// </summary>
        /// <param name="parameter">Parameter to validate.</param>
        /// <param name="pattern">Regex Pattern used to validate parameter.</param>
        /// <returns></returns>
        private static bool ValidateParameter(string parameter, string pattern)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(parameter);

            if (match.Success)            
                return true;            
            else            
                return false;            
        }                
    }
}
