using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Table("PW")]
[Index("Email", Name = "UQ__PW__AB6E6164FCE64998", IsUnique = true)]
public partial class Pw
{
    [Key]
    [Column("PW_id")]
    public int PwId { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("password_hash")]
    [StringLength(255)]
    [Unicode(false)]
    public string PasswordHash { get; set; } = null!;

    [Column("salt")]
    [StringLength(255)]
    [Unicode(false)]
    public string Salt { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }
}
