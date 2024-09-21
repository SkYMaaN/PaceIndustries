using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("POItem")]
[Index("Ponumber", "Poitem1", "CompanyId", Name = "con_unique_poitem_ponumber_poitem_companyid", IsUnique = true)]
public partial class Poitem
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [Column("PONumber")]
    public int Ponumber { get; set; }

    [Column("POItem")]
    public int Poitem1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierId { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? OrderType { get; set; }

    public int OrderNumber { get; set; }

    public int OrderItem { get; set; }

    public bool NoCharge { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? GroupCode { get; set; }

    public bool PurchasedCasting { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal UnitPrice { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal RecvQty { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal ReturnQty { get; set; }

    public bool Complete { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string UnitMeas { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MatlDesc1 { get; set; }

    [Column("MaterialID")]
    [StringLength(22)]
    [Unicode(false)]
    public string? MaterialId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Requester { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Poitems")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("PoitemNavigation")]
    public virtual ICollection<Podate> Podates { get; set; } = new List<Podate>();

    [ForeignKey("Ponumber, CompanyId")]
    [InverseProperty("Poitems")]
    public virtual Poheader Poheader { get; set; } = null!;

    [ForeignKey("SupplierId, CompanyId")]
    [InverseProperty("Poitems")]
    public virtual Supplier Supplier { get; set; } = null!;
}
