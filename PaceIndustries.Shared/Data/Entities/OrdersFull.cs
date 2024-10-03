using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Keyless]
public partial class OrdersFull
{
    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CustomerId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ShipTo { get; set; } = null!;

    public int OrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CustPo { get; set; } = null!;

    public bool ClosedFlag { get; set; }

    public long OdyUniqueId { get; set; }

    public int? OrderItem { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string ProductId { get; set; } = null!;

    public bool Complete { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal SellPrice { get; set; }

    public long OrderItemUniqueId { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string OrderDateProductId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OrderDateCustomerId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OrderDateShipTo { get; set; } = null!;

    public int ReleaseNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReleaseDate { get; set; }

    public int ReleaseQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    public int RequestQty { get; set; }

    public int ShipQty { get; set; }

    public int ReturnQty { get; set; }

    public bool OrderDateComplete { get; set; }

    public long OrderDateUniqueId { get; set; }
}
