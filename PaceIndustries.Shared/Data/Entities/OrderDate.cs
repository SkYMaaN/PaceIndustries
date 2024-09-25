using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("OrderDate")]
[Index("OrderNumber", "OrderItem", "CompanyId", "ReleaseNumber", Name = "con_uq_orderdate", IsUnique = true)]
public partial class OrderDate
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(22)]
    [Unicode(false)]
    public string ProductId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ShipTo { get; set; } = null!;

    public int OrderNumber { get; set; }

    public int OrderItem { get; set; }

    public int ReleaseNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReleaseDate { get; set; }

    public int ReleaseQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    public int RequestQty { get; set; }

    public int ShipQty { get; set; }

    public int ReturnQty { get; set; }

    public bool Complete { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("OrderDates")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("OrderNumber, OrderItem, CompanyId")]
    [InverseProperty("OrderDates")]
    public virtual OrderItem OrderItemNavigation { get; set; } = null!;

    [ForeignKey("ProductId, CompanyId")]
    [InverseProperty("OrderDates")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("ShipTo, CompanyId")]
    [InverseProperty("OrderDates")]
    public virtual ShipTo ShipToNavigation { get; set; } = null!;
}
