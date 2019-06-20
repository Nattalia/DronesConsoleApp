using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Class to perform all movements to a dron
    /// </summary>
    public class DronInit
    {
        public Dron Dron { get; }
        private List<Movement> Movements;

        /// <summary>
        /// Constructor to initialize the dron and its movements
        /// </summary>
        /// <param name="dron"></param>
        /// <param name="movements"></param>
        public DronInit(Dron dron, List<Movement> movements)
        {
            Dron = dron;
            Movements = movements;
        }

        /// <summary>
        /// Performs all movements to a dron
        /// </summary>
        public void MoveDron()
        {
            Broker broker = new Broker();

            foreach (Movement movement in Movements)
            {
                switch (movement)
                {
                    case Movement.L:
                        broker.AddOrder(new TurnLeft(Dron));
                        break;
                    case Movement.R:
                        broker.AddOrder(new TurnRight(Dron));
                        break;
                    case Movement.M:
                        broker.AddOrder(new MoveFordward(Dron));
                        break;
                }
            }
            
            broker.ExecuteOrders();
        }
    }
}
