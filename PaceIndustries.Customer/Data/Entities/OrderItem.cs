using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("OrderItem")]
[Index("OrderNumber", "OrderItem1", "CompanyId", Name = "con_uq_orderitem", IsUnique = true)]
public partial class OrderItem
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    public int OrderNumber { get; set; }

    [Required]
    [Column("OrderItem")]
    public int? OrderItem1 { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string ProductId { get; set; } = null!;

    public bool Complete { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal SellPrice { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [InverseProperty("OrderItemNavigation")]
    public virtual ICollection<OrderDate> OrderDates { get; set; } = new List<OrderDate>();

    [ForeignKey("OrderNumber, CompanyId")]
    [InverseProperty("OrderItems")]
    public virtual OrderHeader OrderHeader { get; set; } = null!;

    [ForeignKey("ProductId, CompanyId")]
    [InverseProperty("OrderItems")]
    public virtual Product Product { get; set; } = null!;
}
