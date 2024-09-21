using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("ForecastDtl")]
public partial class ForecastDtl
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(22)]
    [Unicode(false)]
    public string ProductId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    public int Period { get; set; }

    public int Qty { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal Amt { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal Wgt { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    public int Year { get; set; }

    public int Quarter { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("ForecastDtls")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("Period, Year")]
    [InverseProperty("ForecastDtls")]
    public virtual Period PeriodNavigation { get; set; } = null!;

    [ForeignKey("ProductId, CompanyId")]
    [InverseProperty("ForecastDtls")]
    public virtual Product Product { get; set; } = null!;
}
