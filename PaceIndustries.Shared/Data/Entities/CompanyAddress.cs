using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("CompanyAddress")]
public partial class CompanyAddress
{
    public long Id { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? CoName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FaxNumber { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FederalId { get; set; }

    public DateOnly? LastDate { get; set; }

    public int? LastTime { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LastUser { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? State { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Zipcode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("CompanyAddresses")]
    public virtual Plant Company { get; set; } = null!;
}
