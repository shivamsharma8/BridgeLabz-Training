using System;

class Order{
	
    // Base class attributes
    public int OrderId;
    public string OrderDate;

    // Method to get order status
    public virtual string GetOrderStatus(){
		
        return "Order Placed";
    }
}

// First level child class
class ShippedOrder : Order{
	
    public string TrackingNumber;

    public override string GetOrderStatus(){
		
        return "Order Shipped";
    }
}

// Second level child class
class DeliveredOrder : ShippedOrder{
	
    public string DeliveryDate;

    public override string GetOrderStatus(){
		
        return "Order Delivered";
    }
}

class OrderProgram{
	
    static void Main(){
		
        DeliveredOrder order = new DeliveredOrder();
        order.OrderId = 101;
        order.OrderDate = "10-Jan-2026";
        order.TrackingNumber = "TRK123";
        order.DeliveryDate = "12-Jan-2026";

        Console.WriteLine("Order ID: " + order.OrderId);
        Console.WriteLine("Order Date: " + order.OrderDate);
        Console.WriteLine("Tracking Number: " + order.TrackingNumber);
        Console.WriteLine("Delivery Date: " + order.DeliveryDate);
        Console.WriteLine("Order Status: " + order.GetOrderStatus());
    }
}
