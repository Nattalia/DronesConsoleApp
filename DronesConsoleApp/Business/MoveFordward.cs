using DronesConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Class to make one dron move fordward.
    /// </summary>
    class MoveFordward : IOrder
    {
        private Dron Dron;

        /// <summary>
        /// Constructor to initialize Dron property.
        /// </summary>
        /// <param name="dron">Dron to move fordward.</param>
        public MoveFordward(Dron dron)
        {
            Dron = dron;
        }

        /// <summary>
        /// Metod to make given dron move fordward.
        /// </summary>
        public void Execute()
        {
            Dron.MoveFordward();
        }
    }
}
