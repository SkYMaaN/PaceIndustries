using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

public partial class Operation
{
    [StringLength(15)]
    [Unicode(false)]
    public string? Account { get; set; }

    public bool? Active { get; set; }

    [Column("ActMachFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActMachFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ActMachLabr { get; set; }

    [Column("ActMachVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActMachVovh { get; set; }

    [Column("ActManFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActManFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ActManLabr { get; set; }

    [Column("ActManVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActManVovh { get; set; }

    [Column("ActSetupFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActSetupFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ActSetupLabr { get; set; }

    [Column("ActSetupVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ActSetupVovh { get; set; }

    public bool? AllDays { get; set; }

    public bool? AutoAllocatedHours { get; set; }

    public bool? AutoAllocatedHoursProd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AutoAllocProdMeth { get; set; }

    public bool? AutoRecipeRelief { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BudgetCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CompanyId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CustomerSpecType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DateToUse { get; set; }

    public int? Department { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnableFeedBack { get; set; }

    [Column("EstMachFOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstMachFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? EstMachLabr { get; set; }

    [Column("EstMachVOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstMachVovh { get; set; }

    [Column("EstManFOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstManFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? EstManLabr { get; set; }

    [Column("EstManVOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstManVovh { get; set; }

    [Column("EstSetupFOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstSetupFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? EstSetupLabr { get; set; }

    [Column("EstSetupVOVH", TypeName = "decimal(18, 0)")]
    public decimal? EstSetupVovh { get; set; }

    public bool? Fri { get; set; }

    [Column("FrozMachFOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozMachFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? FrozMachLabr { get; set; }

    [Column("FrozMachVOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozMachVovh { get; set; }

    [Column("FrozManFOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozManFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? FrozManLabr { get; set; }

    [Column("FrozManVOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozManVovh { get; set; }

    [Column("FrozSetupFOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozSetupFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? FrozSetupLabr { get; set; }

    [Column("FrozSetupVOVH", TypeName = "decimal(18, 0)")]
    public decimal? FrozSetupVovh { get; set; }

    public bool? IsHeatTreat { get; set; }

    public DateOnly? LastDate { get; set; }

    public int? LastTime { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LastUser { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LotFormulaCode { get; set; }

    public bool? LotTracking { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? MachineCapacity { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ManCapacity { get; set; }

    public bool? MetalCapacity { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Methinfi { get; set; }

    public long? MoldsCapacity { get; set; }

    public bool? Mon { get; set; }

    public bool? Mstrwgts { get; set; }

    [Column("Operation")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Operation1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? OperationType { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? OverridePercent { get; set; }

    public long? OverrideQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProcessShtTmplate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ProcessSpecType { get; set; }

    [Column("ProjMachFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjMachFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ProjMachLabr { get; set; }

    [Column("ProjMachVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjMachVovh { get; set; }

    [Column("ProjManFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjManFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ProjManLabr { get; set; }

    [Column("ProjManVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjManVovh { get; set; }

    [Column("ProjSetupFOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjSetupFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? ProjSetupLabr { get; set; }

    [Column("ProjSetupVOVH", TypeName = "decimal(18, 0)")]
    public decimal? ProjSetupVovh { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RateType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RecipeRelief { get; set; }

    public bool? RelieveRecipe { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ReportSeries { get; set; }

    public bool? Sat { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ScheduleBy { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? SchedulingGroup { get; set; }

    [Column("SFQDisplayLabel")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SfqdisplayLabel { get; set; }

    [Column("SFQProcessSeries")]
    [StringLength(35)]
    [Unicode(false)]
    public string? SfqprocessSeries { get; set; }

    [Column("SFQShowinQV")]
    public bool? SfqshowinQv { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShopCardTmplate { get; set; }

    public TimeOnly? StartTime { get; set; }

    [Column("StdMachFOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdMachFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? StdMachLabr { get; set; }

    [Column("StdMachVOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdMachVovh { get; set; }

    [Column("StdManFOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdManFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? StdManLabr { get; set; }

    [Column("StdManVOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdManVovh { get; set; }

    [Column("StdSetupFOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdSetupFovh { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? StdSetupLabr { get; set; }

    [Column("StdSetupVOVH", TypeName = "decimal(18, 0)")]
    public decimal? StdSetupVovh { get; set; }

    public TimeOnly? StopTime { get; set; }

    public bool? Sun { get; set; }

    public bool? Thu { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ToolShopCardTmplate { get; set; }

    public bool? Track { get; set; }

    public bool? Tue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Key]
    public long UniqueId { get; set; }

    public bool? Wed { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? WgtCapacity { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? WorkCenter { get; set; }
}
