using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

[Table("pSupplierAck")]
public partial class PSupplierAck
{
    [StringLength(4)]
    [Unicode(false)]
    public string? ParentCompanyId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentKey { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTimeStamp { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("ack")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Ack { get; set; }

    [Key]
    public long Id { get; set; }
}
