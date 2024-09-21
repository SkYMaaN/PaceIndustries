using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Customer.Data.Entities;

[Table("SupplierX")]
public partial class SupplierX
{
    [Key]
    public long Id { get; set; }

    public long ParentId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MetalVendor { get; set; }

    public bool? Critical { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("SupplierXes")]
    public virtual Supplier Parent { get; set; } = null!;
}
