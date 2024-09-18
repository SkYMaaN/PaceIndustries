using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("Matltype")]
public partial class Matltype
{
    [StringLength(15)]
    [Unicode(false)]
    public string? Account { get; set; }

    public bool? Active { get; set; }

    public bool? AddBackInv { get; set; }

    [Column("BaseMType")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BaseMtype { get; set; }

    public bool? CalcLossValue { get; set; }

    public bool? CalcOxidation { get; set; }

    public DateOnly? ChangeDate { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ChargeWeight { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CompanyId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? CurrentPrice { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? EstCost { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? EstLoss { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? EstSprue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? FrozenCost { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? FrozenSprueCost { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? FrozenStdLoss { get; set; }

    public DateOnly? LastDate { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LastPrice { get; set; }

    public int? LastTime { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LastUser { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? MatlInvId { get; set; }

    public bool? MetalRecovery { get; set; }

    [Column("MType")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Mtype { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ProjStdCost { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? ProjStdLoss { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ProjStdSprue { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ReturnAccount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ScrapVarAccount { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SprueCost { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? StdCost { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? StdLoss { get; set; }

    [Key]
    public int UniqueId { get; set; }
}
