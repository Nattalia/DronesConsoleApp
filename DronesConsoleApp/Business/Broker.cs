using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Business
{
    /// <summary>
    /// Class to execute list of orders in a dron.
    /// </summary>
    class Broker
    {
        private List<IOrder> OrderList = new List<IOrder>();

        /// <summary>
        /// Method to add order to list.
        /// </summary>
        /// <param name="order">Order to add</param>
        public void AddOrder(IOrder order)
        {
            OrderList.Add(order);
        }

        /// <summary>
        /// Method to execute list of orders.
        /// </summary>
        public void ExecuteOrders()
        {
            foreach (IOrder order in OrderList)
            {
                order.Execute();
            }
        }
    }
}
