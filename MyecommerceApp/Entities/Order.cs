using System;
using System.Collections.Generic;

namespace MyecommerceApp.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime DateOfPurchase { get; set; }

    public decimal TotalPrice { get; set; }

    public string ShippingDetails { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
    
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}