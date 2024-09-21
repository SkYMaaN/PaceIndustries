using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Table("Plant")]
[Index("CompanyId", Name = "UQ__Plant__2D971CAD856D56FA", IsUnique = true)]
[Index("BranchId", Name = "UQ__Plant__A1682FC40D659403", IsUnique = true)]
[Index("DivId", Name = "UQ__Plant__F195144FDF1AEE3C", IsUnique = true)]
public partial class Plant
{
    [Key]
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string BranchId { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string DivId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [InverseProperty("Company")]
    public virtual ICollection<Apopen> Apopens { get; set; } = new List<Apopen>();

    [InverseProperty("ParentCompany")]
    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    [InverseProperty("Company")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [InverseProperty("Company")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [InverseProperty("Company")]
    public virtual ICollection<Podate> Podates { get; set; } = new List<Podate>();

    [InverseProperty("Company")]
    public virtual ICollection<Poheader> Poheaders { get; set; } = new List<Poheader>();

    [InverseProperty("Company")]
    public virtual ICollection<Poitem> Poitems { get; set; } = new List<Poitem>();

    [InverseProperty("Company")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    [InverseProperty("Company")]
    public virtual ICollection<ShipTo> ShipTos { get; set; } = new List<ShipTo>();

    [InverseProperty("Company")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
