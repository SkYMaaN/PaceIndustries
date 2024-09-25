using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("ReqHdr")]
[Index("ReqNumber", "CompanyId", Name = "con_unique_reqhdr_reqnumber_companyid", IsUnique = true)]
public partial class ReqHdr
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SupplierId { get; set; }

    public int ReqNumber { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PurchAgent { get; set; }

    public bool? Closed { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrCode { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? EnteredBy { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ReqHdrs")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("ReqHdr")]
    public virtual ICollection<ReqItem> ReqItems { get; set; } = new List<ReqItem>();

    [ForeignKey("SupplierId, CompanyId")]
    [InverseProperty("ReqHdrs")]
    public virtual Supplier? Supplier { get; set; }
}
