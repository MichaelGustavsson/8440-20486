using Microsoft.AspNet.SignalR.Hubs;
using SimpleSignalRDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSignalRDemo.Hub
{
    [HubName("OrderStatusHub")]
    public class SimpleHub: Microsoft.AspNet.SignalR.Hub
    {
        //Declare and instantiate a list for keeping track of new orders.
        static readonly IList<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            //Update incoming order with an orderdate.
            order.OrderDate = DateTime.Now.ToString();
            //Add the order to our fake orderlist.
            _orders.Add(order);
            //Define the callback method which the client need to create to be able to listen for broadcasts.            
            Clients.All.OnAddOrder(_orders);
        }
    }
}