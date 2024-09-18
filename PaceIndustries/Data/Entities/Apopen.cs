using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("APOpen")]
public partial class Apopen
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    public long VouchRefNum { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierId { get; set; } = null!;

    public int Division { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CurrCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string SupplierInvNum { get; set; } = null!;

    [Column("GLDate", TypeName = "datetime")]
    public DateTime Gldate { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal GrossDollars { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Termcode { get; set; } = null!;

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Apopens")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("SupplierId, CompanyId")]
    [InverseProperty("Apopens")]
    public virtual Supplier Supplier { get; set; } = null!;
}
