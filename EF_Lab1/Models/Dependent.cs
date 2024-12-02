using System;
using System.Collections.Generic;

namespace EF_Lab1.Models;

public partial class Dependent
{
    public int Essn { get; set; }

    public string DependentName { get; set; } = null!;

    public string? Sex { get; set; }

    public DateOnly? Bdate { get; set; }

    public string? Relationship { get; set; }

    public virtual Employee EssnNavigation { get; set; } = null!;
}
