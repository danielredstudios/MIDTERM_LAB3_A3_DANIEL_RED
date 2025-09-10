using System;
using System.Collections.Generic;

namespace MIDTERM_LAB3_DANIEL_RED.Models;

public partial class Student
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? Age { get; set; }

    public string? Course { get; set; }
}