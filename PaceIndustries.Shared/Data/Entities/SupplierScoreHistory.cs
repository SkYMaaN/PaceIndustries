using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Keyless]
[Table("SupplierScoreHistory")]
public partial class SupplierScoreHistory
{
    [Column(TypeName = "datetime")]
    public DateTime? Month { get; set; }

    [Column("Supplier ID")]
    [StringLength(255)]
    public string? SupplierId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [Column("Master Commodity")]
    [StringLength(255)]
    public string? MasterCommodity { get; set; }

    public double? Score { get; set; }

    [StringLength(255)]
    public string? Rating { get; set; }

    [Column("Payment Terms")]
    public double? PaymentTerms { get; set; }

    [Column("OTD")]
    public double? Otd { get; set; }

    [Column("Cost Savings")]
    public double? CostSavings { get; set; }

    [Column("Open CAR/CI")]
    [StringLength(255)]
    public string? OpenCarCi { get; set; }

    [Column("Compliance Response")]
    public double? ComplianceResponse { get; set; }
}
