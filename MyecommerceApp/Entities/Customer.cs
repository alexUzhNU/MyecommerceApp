using System;
using System.Collections.Generic;

namespace MyecommerceApp.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string BillingAddress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
