using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSignalRDemo.Models
{
    public class Order
    {
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
    }
}