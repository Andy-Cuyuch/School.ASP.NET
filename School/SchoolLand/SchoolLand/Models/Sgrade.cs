using System;
using System.Collections.Generic;

namespace SchoolLand.Models;

public partial class Sgrade
{
    public int DegreeId { get; set; }

    public string Grade { get; set; } = null!;

    public string Descriptions { get; set; } = null!;

    public int? Student { get; set; }

    public virtual Student? StudentNavigation { get; set; }
}
