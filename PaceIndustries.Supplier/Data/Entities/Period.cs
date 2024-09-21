using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[PrimaryKey("PeriodNumber", "Year")]
[Table("Period")]
public partial class Period
{
    public long Id { get; set; }

    [Key]
    public int PeriodNumber { get; set; }

    [Key]
    public int Year { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string Month { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [InverseProperty("PeriodNavigation")]
    public virtual ICollection<ForecastDtl> ForecastDtls { get; set; } = new List<ForecastDtl>();

    [InverseProperty("PeriodNavigation")]
    public virtual ICollection<SalesHistoryDtl> SalesHistoryDtls { get; set; } = new List<SalesHistoryDtl>();
}
