using System;
using System.Collections.Generic;

namespace EF_Lab1.Models;

public partial class Employee
{
    public int Ssn { get; set; }

    public string? Fname { get; set; }

    public string? Minit { get; set; }

    public string? Lname { get; set; }

    public DateOnly? Bdate { get; set; }

    public string? Address { get; set; }

    public string? Sex { get; set; }

    public decimal? Salary { get; set; }

    public int? Superssn { get; set; }

    public int? Dno { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();

    public virtual Department? DnoNavigation { get; set; }

    public virtual ICollection<Employee> InverseSuperssnNavigation { get; set; } = new List<Employee>();

    public virtual Employee? SuperssnNavigation { get; set; }

    public virtual ICollection<WorksOn> WorksOns { get; set; } = new List<WorksOn>();
}
