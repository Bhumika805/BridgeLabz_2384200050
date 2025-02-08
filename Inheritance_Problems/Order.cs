using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: Order
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual void GetOrderStatus()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
            Console.WriteLine("Status: Order Placed");
        }
    }

    // Subclass: ShippedOrder (Inherits from Order)
    class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine($"Tracking Number: {TrackingNumber}");
            Console.WriteLine("Status: Order Shipped");
        }
    }

    // Subclass: DeliveredOrder (Inherits from ShippedOrder)
    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
            Console.WriteLine("Status: Order Delivered");
        }
    }
}

