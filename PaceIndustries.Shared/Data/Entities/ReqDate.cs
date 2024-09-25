using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("ReqDate")]
public partial class ReqDate
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    public int ReqNumber { get; set; }

    public int ReqItem { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PromiseDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal RequestQty { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ReqDates")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("ReqNumber, ReqItem, CompanyId")]
    [InverseProperty("ReqDates")]
    public virtual ReqItem ReqItemNavigation { get; set; } = null!;
}
