using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Table("Product")]
[Index("ProductId", "CompanyId", Name = "con_uq_product", IsUnique = true)]
public partial class Product
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    [StringLength(22)]
    [Unicode(false)]
    public string ProductId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string CustPart { get; set; } = null!;

    [Column("MType")]
    [StringLength(10)]
    [Unicode(false)]
    public string Mtype { get; set; } = null!;

    public bool Active { get; set; }

    [Column(TypeName = "decimal(16, 5)")]
    public decimal NetWgt { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Products")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("CustomerId, CompanyId")]
    [InverseProperty("Products")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Product")]
    public virtual ICollection<ForecastDtl> ForecastDtls { get; set; } = new List<ForecastDtl>();

    [InverseProperty("Product")]
    public virtual ICollection<OrderDate> OrderDates { get; set; } = new List<OrderDate>();

    [InverseProperty("Product")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [InverseProperty("Product")]
    public virtual ICollection<SalesHistoryDtl> SalesHistoryDtls { get; set; } = new List<SalesHistoryDtl>();
}
