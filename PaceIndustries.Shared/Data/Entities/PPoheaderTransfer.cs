using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("pPOHeaderTransfer")]
public partial class PPoheaderTransfer
{
    [Key]
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierId { get; set; } = null!;

    [Column("PONumber")]
    public int? Ponumber { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PurchAgent { get; set; }

    public bool? Closed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PoDate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Termcode { get; set; }

    [Column("ACKStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Ackstatus { get; set; }

    public long? OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateTimeStamp { get; set; }

    public bool? Processed { get; set; }
}
