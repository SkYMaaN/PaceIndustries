using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Supplier.Data.Entities;

[Keyless]
[Table("SupplierXDailyParents")]
public partial class SupplierXdailyParent
{
    public long ParentId { get; set; }

    [ForeignKey("ParentId")]
    public virtual Supplier Parent { get; set; } = null!;
}
