using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("pnProduct")]
public partial class PnProduct
{
    [Key]
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? CustomerName { get; set; }

    public int? ProductId { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string? CustPart { get; set; }

    [Column("MType")]
    [StringLength(50)]
    public string? Mtype { get; set; }

    public bool? Active { get; set; }

    [Column(TypeName = "decimal(10, 5)")]
    public decimal? NetWgt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTimeStamp { get; set; }

    [StringLength(50)]
    public string? QuoteNumber { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }
}
