using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Class to make one dron turn left.
    /// </summary>
    class TurnLeft : IOrder
    {
        private Dron Dron;

        /// <summary>
        /// Constructor to initialize Dron property.
        /// </summary>
        /// <param name="dron">Dron to turn left.</param>
        public TurnLeft(Dron dron)
        {
            Dron = dron;
        }

        /// <summary>
        /// Metod to make given dron turn left.
        /// </summary>
        public void Execute()
        {
            Dron.TurnLeft();
        }
    }
}
