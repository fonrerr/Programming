using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder: Order
    {
        public string DeliveryTime { get; set; }

        public PriorityOrder() 
        {
        }

        public PriorityOrder(string customerName, Address address, List<Item> items, string deliveryTime) :
            base(customerName, address, items)
        {
            DeliveryTime = deliveryTime;
        }
    }
}
