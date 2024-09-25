using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("PODate")]
[Index("Ponumber", "Poitem", "RelNum", "CompanyId", Name = "con_unique_podate_ponumber_poitem_relnum_companyid", IsUnique = true)]
public partial class Podate
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [Column("PONumber")]
    public int Ponumber { get; set; }

    [Column("POItem")]
    public int Poitem { get; set; }

    public int RelNum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PromiseDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal RequestQty { get; set; }

    public bool Complete { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecvDate { get; set; }

    [Column(TypeName = "decimal(14, 2)")]
    public decimal RecvQty { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Podates")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("Ponumber, Poitem, CompanyId")]
    [InverseProperty("Podates")]
    public virtual Poitem PoitemNavigation { get; set; } = null!;
}
