using System;
using System.Collections.Generic;

namespace EF_Lab1.Models;

public partial class WorksOn
{
    public int Essn { get; set; }

    public int Pno { get; set; }

    public decimal? Hours { get; set; }

    public virtual Employee EssnNavigation { get; set; } = null!;

    public virtual Project PnoNavigation { get; set; } = null!;
}
