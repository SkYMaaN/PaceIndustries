using System;
using System.Collections.Generic;

namespace PaceIndustries;

public partial class PSupplierUploadFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? Email { get; set; }

    public string? ParentKey { get; set; }

    public string? ParentCompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }
}
