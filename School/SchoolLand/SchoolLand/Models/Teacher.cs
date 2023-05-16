using System;
using System.Collections.Generic;

namespace SchoolLand.Models;

public partial class Teacher
{
    public int IdTeacher { get; set; }

    public string NameTeacher { get; set; } = null!;

    public string Age { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Carnet { get; set; } = null!;

    public string YearsSchool { get; set; } = null!;
}
