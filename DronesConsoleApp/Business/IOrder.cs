using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Interfaz to execute one single order.
    /// </summary>
    interface IOrder
    {
        /// <summary>
        /// Method to execute one single order.
        /// </summary>
        void Execute();
    }
}
