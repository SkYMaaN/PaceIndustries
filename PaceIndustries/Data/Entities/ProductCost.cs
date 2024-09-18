using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("ProductCost")]
public partial class ProductCost
{
    [Column("BOMFixOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomfixOhdollars { get; set; }

    [Column("BOMFixOHScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomfixOhscrapDollars { get; set; }

    [Column("BOMLaborDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomlaborDollars { get; set; }

    [Column("BOMLaborScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomlaborScrapDollars { get; set; }

    [Column("BOMMatlDollars", TypeName = "decimal(18, 0)")]
    public decimal? BommatlDollars { get; set; }

    [Column("BOMMatlScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? BommatlScrapDollars { get; set; }

    [Column("BOMVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomvarOhdollars { get; set; }

    [Column("BOMVarOHScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? BomvarOhscrapDollars { get; set; }

    [Column("CompanyID")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CompanyId { get; set; }

    [Column("CoreFixOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? CoreFixOhdollars { get; set; }

    [Column("CoreFixOHScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? CoreFixOhscrapDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CoreLaborDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CoreLaborScrapDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CoreMatlDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CoreMatlScrapDollars { get; set; }

    [Column("CoreVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? CoreVarOhdollars { get; set; }

    [Column("CoreVarOHScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? CoreVarOhscrapDollars { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CostType { get; set; }

    public DateOnly? LastCostDate { get; set; }

    public DateOnly? LastDate { get; set; }

    public int? LastTime { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LastUser { get; set; }

    [Column("MTypeCostLb", TypeName = "decimal(18, 0)")]
    public decimal? MtypeCostLb { get; set; }

    [Column("MTypeDollars", TypeName = "decimal(18, 0)")]
    public decimal? MtypeDollars { get; set; }

    [Column("MTypeGrossDollars", TypeName = "decimal(18, 0)")]
    public decimal? MtypeGrossDollars { get; set; }

    [Column("MTypeLossDollar", TypeName = "decimal(18, 0)")]
    public decimal? MtypeLossDollar { get; set; }

    [Column("MTypePrice", TypeName = "decimal(18, 0)")]
    public decimal? MtypePrice { get; set; }

    [Column("MTypeScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? MtypeScrapDollars { get; set; }

    [Column("MTypeSprueDollars", TypeName = "decimal(18, 0)")]
    public decimal? MtypeSprueDollars { get; set; }

    public int? OrderItem { get; set; }

    public int? OrderNumber { get; set; }

    [Column("OSCostDollars", TypeName = "decimal(18, 0)")]
    public decimal? OscostDollars { get; set; }

    [Column("OSScrapDollars", TypeName = "decimal(18, 0)")]
    public decimal? OsscrapDollars { get; set; }

    public long? ParentId { get; set; }

    [Column("PrevSetupFixedOH", TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupFixedOh { get; set; }

    [Column("PrevSetupFixedOHEach", TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupFixedOheach { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupLabor { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupLaborEach { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupMatl { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupMatlEach { get; set; }

    [Column("PrevSetupVarOH", TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupVarOh { get; set; }

    [Column("PrevSetupVarOHEach", TypeName = "decimal(18, 0)")]
    public decimal? PrevSetupVarOheach { get; set; }

    [Column("PrevToolingFixOH", TypeName = "decimal(18, 0)")]
    public decimal? PrevToolingFixOh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevToolingLabor { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevToolingMatl { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PrevToolingSetup { get; set; }

    [Column("PrevToolingVarOH", TypeName = "decimal(18, 0)")]
    public decimal? PrevToolingVarOh { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? ProductQuote { get; set; }

    [Column("QP")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Qp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RtgCode { get; set; }

    [Column("RtgFixedOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? RtgFixedOhdollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RtgLaborDollars { get; set; }

    [Column("RtgScrapBOMDollars", TypeName = "decimal(18, 0)")]
    public decimal? RtgScrapBomdollars { get; set; }

    [Column("RtgScrapFixOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? RtgScrapFixOhdollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RtgScrapLaborDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RtgScrapMetalDollars { get; set; }

    [Column("RtgScrapVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? RtgScrapVarOhdollars { get; set; }

    [Column("RtgVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? RtgVarOhdollars { get; set; }

    [Column("SetupFixedOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? SetupFixedOhdollars { get; set; }

    [Column("SetupFixedOHEach", TypeName = "decimal(18, 0)")]
    public decimal? SetupFixedOheach { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? SetupLaborDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? SetupLaborEach { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? SetupMatlDollars { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? SetupMatlEach { get; set; }

    [Column("SetupVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? SetupVarOhdollars { get; set; }

    [Column("SetupVarOHEach", TypeName = "decimal(18, 0)")]
    public decimal? SetupVarOheach { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? SprueCostLb { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ToolingCost { get; set; }

    [Column("ToolingFixOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? ToolingFixOhdollars { get; set; }

    [Column("ToolingFixOHMU", TypeName = "decimal(18, 0)")]
    public decimal? ToolingFixOhmu { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ToolingHours { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ToolingLaborDollars { get; set; }

    [Column("ToolingLaborMU", TypeName = "decimal(18, 0)")]
    public decimal? ToolingLaborMu { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ToolingMatlDollars { get; set; }

    [Column("ToolingMatlMU", TypeName = "decimal(18, 0)")]
    public decimal? ToolingMatlMu { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ToolingPrice { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ToolingSetupDollars { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ToolingSetupHrs { get; set; }

    [Column("ToolingVarOHDollars", TypeName = "decimal(18, 0)")]
    public decimal? ToolingVarOhdollars { get; set; }

    [Column("ToolingVarOHMU", TypeName = "decimal(18, 0)")]
    public decimal? ToolingVarOhmu { get; set; }

    [Key]
    public long UniqueId { get; set; }
}
