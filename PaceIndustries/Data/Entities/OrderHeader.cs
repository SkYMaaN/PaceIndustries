using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("OrderHeader")]
[Index("OrderNumber", "CompanyId", Name = "con_uq_orderheader", IsUnique = true)]
public partial class OrderHeader
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
    public string ShipTo { get; set; } = null!;

    public int OrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CustPo { get; set; } = null!;

    public bool ClosedFlag { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("OrderHeaders")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("OrderHeaders")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("OrderHeader")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [ForeignKey("ShipTo, CompanyId")]
    [InverseProperty("OrderHeaders")]
    public virtual ShipTo ShipToNavigation { get; set; } = null!;
}
