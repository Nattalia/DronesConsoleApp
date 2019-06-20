using DronesConsoleApp.Business;
using DronesConsoleApp.Common;
using DronesConsoleApp.CustomException;
using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;

namespace DronesConsoleApp
{
    public class Program
    {   
        /// <summary>
        /// Main. App input.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {                
                Console.WriteLine("--------");
                Console.WriteLine("INPUT");
                Console.WriteLine("--------");

                string flyingArea = GetFlyingAreaFromConsole();
                List<string> dronesParameters = GetDronesParametersFromConsole();

                List<DronInit> dronsToMove = ParseDronesParameters(flyingArea, dronesParameters);

                Console.WriteLine("--------");
                Console.WriteLine("OUTPUT");
                Console.WriteLine("--------");

                MoveAllDrones(dronsToMove);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(Messages.generalExceptionMessage, ex.Message, ex.StackTrace));
            }
            finally
            {
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Method to obtain flying area from console
        /// </summary>
        /// <returns>Flying area. Format: Width Height</returns>
        public static string GetFlyingAreaFromConsole()
        {           
            return InputHelper.GetValidInputParameter(Messages.flyingArea, Messages.flyingAreaRegexPattern);
        }

        /// <summary>
        /// Method to obtain all drones and its movements from console.
        /// </summary>
        /// <returns>Drones initial position and movements. Format of each string element in the list: InitialPosition|Movements 
        ///     - InitialPosition: XAxis YAxis Direction
        ///     - Movements: List of Movements
        ///     - Example: 5 5 S|LMMRM
        /// </returns>
        public static List<string> GetDronesParametersFromConsole()
        {
            // Ask for Number of Drones to the User.            
            string numberDrones = InputHelper.GetValidInputParameter(Messages.numberDrones, Messages.numberDronesRegexPattern);

            // Ask for drones information: start position and movements
            List<string> dronesParameters = new List<string>();

            for (int i = 0; i < Int32.Parse(numberDrones); i++)
            {                
                string startPosition = InputHelper.GetValidInputParameter(string.Format(Messages.dronStartPosition, i + 1), Messages.dronStartPositionRegexPattern);                
                string movements = InputHelper.GetValidInputParameter(string.Format(Messages.dronMovements, i + 1), Messages.dronMovementsRegexPattern);
                
                dronesParameters.Add(string.Format("{0}|{1}", startPosition, movements));
            }

            return dronesParameters;
        }

        /// <summary>
        /// Method to obtain all drones and its movements.
        /// </summary>
        /// <param name="flyingArea">Flying Area. Format: Width Height</param>
        /// <param name="dronesParameters">Drones initial position and movements. Format of each element: InitialPosition|Movements 
        ///     - InitialPosition: XAxis YAxis Direction
        ///     - Movements: List of Movements
        ///     - Example: 5 5 S|LMMRM
        /// </param>
        /// <returns></returns>
        public static List<DronInit> ParseDronesParameters(string flyingArea, List<string> dronesParameters)
        {
            List<DronInit> dronsToMove = new List<DronInit>();

            // Get Flying Area
            string[] flyingAreaArray = flyingArea.Split(" ");
            int width = Int32.Parse(flyingAreaArray[0]);
            int height = Int32.Parse(flyingAreaArray[1]);

            FlyingArea FlyingArea = new FlyingArea(width, height);

            // Get Drones. Start position and list of movements            
            foreach (string droneParameter in dronesParameters)
            {                
                string[] dronesParametersArray = droneParameter.Split("|");

                string[] startPositionArray = dronesParametersArray[0].Split(" ");
                int xAxis = Int32.Parse(startPositionArray[0]);
                int yAxis = Int32.Parse(startPositionArray[1]);
                Direction dir = Utils.DirectionMapper(startPositionArray[2]);
                
                Dron dron = new Dron(FlyingArea, xAxis, yAxis, dir);

                string movements = dronesParametersArray[1];
                List<Movement> lMovements = new List<Movement>();

                foreach (char character in movements)
                {
                    lMovements.Add(Utils.MovementMapper(character));
                }

                DronInit dronInit = new DronInit(dron, lMovements);
                dronsToMove.Add(dronInit);                
            }

            return dronsToMove;
        }        

        /// <summary>
        /// Method to move all drones and get output
        /// </summary>
        /// <param name="dronsToMove"></param>
        public static void MoveAllDrones(List<DronInit> dronsToMove)
        {
            int i = 0;

            foreach (DronInit dronInit in dronsToMove)
            {               
                i++;

                try
                {
                    if (Utils.Between(dronInit.Dron.XPosition, 0, dronInit.Dron.FlyingArea.Width) && 
                        Utils.Between(dronInit.Dron.YPosition, 0, dronInit.Dron.FlyingArea.Height)) // Only include drones inside flying area.
                    {
                        // Move dron
                        dronInit.MoveDron();   
                    
                        Console.WriteLine(string.Format(Messages.dronPosition, i, dronInit.Dron.ToString(), string.Empty));
                    }
                    else
                        Console.WriteLine(string.Format(Messages.dronInitOutsideFlyingArea, i));
                }
                catch (OutOfFlyingAreaException ex)
                {
                    Console.WriteLine(string.Format(Messages.dronPosition, i, dronInit.Dron.ToString(), ex.Message));
                }                
            }
        }
    }
}
