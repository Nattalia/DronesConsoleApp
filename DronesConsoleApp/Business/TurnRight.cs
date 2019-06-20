using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Class to make one dron turn right.
    /// </summary>
    class TurnRight : IOrder
    {
        private Dron Dron;

        /// <summary>
        /// Constructor to initialize Dron property.
        /// </summary>
        /// <param name="dron">Dron to turn right.</param>
        public TurnRight(Dron dron)
        {
            Dron = dron;
        }

        /// <summary>
        /// Metod to make given dron turn right.
        /// </summary>
        public void Execute()
        {
            Dron.TurnRight();
        }
    }
}
