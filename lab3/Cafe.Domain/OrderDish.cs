﻿using System;
using System.Collections.Generic;

namespace lab3.Cafe.Domain;

public partial class OrderDish
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int DishId { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
