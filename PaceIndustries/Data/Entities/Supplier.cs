using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("Supplier")]
[Index("SupplierId", "CompanyId", Name = "con_unique_supplier_supplierid", IsUnique = true)]
public partial class Supplier
{
    public long Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierId { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ApName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? PoName { get; set; }

    public bool Active { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Termcode { get; set; } = null!;

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Apopen> Apopens { get; set; } = new List<Apopen>();

    [ForeignKey("CompanyId")]
    [InverseProperty("Suppliers")]
    public virtual Plant Company { get; set; } = null!;

    [InverseProperty("Supplier")]
    public virtual ICollection<Poheader> Poheaders { get; set; } = new List<Poheader>();

    [InverseProperty("Supplier")]
    public virtual ICollection<Poitem> Poitems { get; set; } = new List<Poitem>();

    [InverseProperty("Parent")]
    public virtual ICollection<SupplierX> SupplierXes { get; set; } = new List<SupplierX>();
}
