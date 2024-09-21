using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Table("Customer")]
[Index("CustomerId", "CompanyId", Name = "con_uq_customer", IsUnique = true)]
public partial class Customer
{
    public long Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string CoName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentCustomerId { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    public bool Active { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TermCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Customers")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<ForecastDtl> ForecastDtls { get; set; } = new List<ForecastDtl>();

    [InverseProperty("Customer")]
    public virtual ICollection<OrderDate> OrderDates { get; set; } = new List<OrderDate>();

    [InverseProperty("Customer")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [InverseProperty("Customer")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    [InverseProperty("Customer")]
    public virtual ICollection<SalesHistoryDtl> SalesHistoryDtls { get; set; } = new List<SalesHistoryDtl>();

    [InverseProperty("Customer")]
    public virtual ICollection<ShipTo> ShipTos { get; set; } = new List<ShipTo>();
}
