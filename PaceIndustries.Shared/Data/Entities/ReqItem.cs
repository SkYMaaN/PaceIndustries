using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("ReqItem")]
[Index("ReqNumber", "ReqItem1", "CompanyId", Name = "con_unique_reqitem_reqnumber_reqitem_companyid", IsUnique = true)]
public partial class ReqItem
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    public int ReqNumber { get; set; }

    [Column("ReqItem")]
    public int ReqItem1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string EnteredBy { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string InvType { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ItemStatus { get; set; } = null!;

    [StringLength(22)]
    [Unicode(false)]
    public string? MaterialId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderBy { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestedBy { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal UnitPrice { get; set; }

    public bool? UpdatePrice { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ReqItems")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("ReqItemNavigation")]
    public virtual ICollection<ReqDate> ReqDates { get; set; } = new List<ReqDate>();

    [ForeignKey("ReqNumber, CompanyId")]
    [InverseProperty("ReqItems")]
    public virtual ReqHdr ReqHdr { get; set; } = null!;
}
