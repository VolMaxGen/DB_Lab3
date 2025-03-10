﻿using System;
using System.Collections.Generic;

namespace lab3.Cafe.Domain;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public int? Age { get; set; }

    public string? Education { get; set; }

    public int ProfessionId { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Profession Profession { get; set; } = null!;
}
