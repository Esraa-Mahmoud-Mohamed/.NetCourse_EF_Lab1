using System;
using System.Collections.Generic;

namespace EF_Lab1.Models;

public partial class Department
{
    public int Dnumber { get; set; }

    public string? Dname { get; set; }

    public int? Mgrssn { get; set; }

    public DateOnly? Mgrstartdate { get; set; }

    public virtual ICollection<DeptLocation> DeptLocations { get; set; } = new List<DeptLocation>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Employee? MgrssnNavigation { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
