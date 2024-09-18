using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("Contact")]
public partial class Contact
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ParentCompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ParentKey { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [Column("Contact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contact1 { get; set; }

    public int ContactPrty { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ContactType { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    public bool Active { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("ParentCompanyId")]
    [InverseProperty("Contacts")]
    public virtual Plant ParentCompany { get; set; } = null!;
}
