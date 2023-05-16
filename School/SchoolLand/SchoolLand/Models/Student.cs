using System;
using System.Collections.Generic;

namespace SchoolLand.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string NameStudent { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Carnet { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual ICollection<Sgrade> Sgrades { get; set; } = new List<Sgrade>();
}
