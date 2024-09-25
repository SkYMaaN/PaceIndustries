using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("pSupplierUploadASMT")]
public partial class PSupplierUploadAsmt
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("file_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FilePath { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ParentKey { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ParentCompanyId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }
}
