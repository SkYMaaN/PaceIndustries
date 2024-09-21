using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("SalesHistoryDtl")]
public partial class SalesHistoryDtl
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

    [StringLength(10)]
    [Unicode(false)]
    public string ShipTo { get; set; } = null!;

    public int Period { get; set; }

    public int Year { get; set; }

    public int Quantity { get; set; }

    public int InvNumber { get; set; }

    public int Item { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal UnitPrice { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("SalesHistoryDtls")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("Period, Year")]
    [InverseProperty("SalesHistoryDtls")]
    public virtual Period PeriodNavigation { get; set; } = null!;

    [ForeignKey("ProductId, CompanyId")]
    [InverseProperty("SalesHistoryDtls")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("ShipTo, CompanyId")]
    [InverseProperty("SalesHistoryDtls")]
    public virtual ShipTo ShipToNavigation { get; set; } = null!;
}
