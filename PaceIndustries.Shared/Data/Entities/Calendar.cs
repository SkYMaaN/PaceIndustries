using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("Calendar")]
public partial class Calendar
{
    [Key]
    public int Id { get; set; }

    public DateOnly CalendarDate { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Day { get; set; }
}
