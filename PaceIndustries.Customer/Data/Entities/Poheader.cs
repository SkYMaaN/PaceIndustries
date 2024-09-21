using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("POHeader")]
[Index("Ponumber", "CompanyId", Name = "con_unique_poheader_ponumber_companyid", IsUnique = true)]
public partial class Poheader
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierId { get; set; } = null!;

    [Column("PONumber")]
    public int Ponumber { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PurchAgent { get; set; }

    public bool Closed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PoDate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CurrCode { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string Termcode { get; set; } = null!;

    [Column("ACKStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string Ackstatus { get; set; } = null!;

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Poheaders")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("Poheader")]
    public virtual ICollection<Poitem> Poitems { get; set; } = new List<Poitem>();

    [ForeignKey("SupplierId, CompanyId")]
    [InverseProperty("Poheaders")]
    public virtual Supplier Supplier { get; set; } = null!;
}
