﻿using System;
using System.Collections.Generic;

namespace MyecommerceApp.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string TransactionDetails { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
