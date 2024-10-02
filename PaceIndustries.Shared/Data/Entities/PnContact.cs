using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("pnContact")]
public partial class PnContact
{
    [Key]
    public long Id { get; set; }

    [StringLength(75)]
    public string? CustomerName { get; set; }

    [StringLength(75)]
    public string? CustomerWebsite { get; set; }

    [StringLength(255)]
    public string? CustomerLocation { get; set; }

    [StringLength(20)]
    public string? TableName { get; set; }

    [StringLength(50)]
    public string? Contact { get; set; }

    public int? ContactPrty { get; set; }

    [StringLength(100)]
    public string? ContactType { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    [StringLength(255)]
    public string Email { get; set; } = null!;

    public bool Active { get; set; }

    [StringLength(50)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? LeadSource { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTimeStamp { get; set; }
}
