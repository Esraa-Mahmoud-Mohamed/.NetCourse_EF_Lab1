using System;
using System.Collections.Generic;

namespace EF_Lab1.Models;

public partial class Project
{
    public int Pnumber { get; set; }

    public string? Pname { get; set; }

    public string? Plocation { get; set; }

    public int? Dnum { get; set; }

    public virtual Department? DnumNavigation { get; set; }

    public virtual ICollection<WorksOn> WorksOns { get; set; } = new List<WorksOn>();
}
