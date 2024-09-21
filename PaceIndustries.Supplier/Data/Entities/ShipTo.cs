using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Table("ShipTo")]
[Index("OdyShipToId", "CompanyId", Name = "con_uq_shipto", IsUnique = true)]
public partial class ShipTo
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OdyShipToId { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string? ShipToName { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ShipTos")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("ShipTos")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("ShipToNavigation")]
    public virtual ICollection<OrderDate> OrderDates { get; set; } = new List<OrderDate>();

    [InverseProperty("ShipToNavigation")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [InverseProperty("ShipToNavigation")]
    public virtual ICollection<SalesHistoryDtl> SalesHistoryDtls { get; set; } = new List<SalesHistoryDtl>();
}
