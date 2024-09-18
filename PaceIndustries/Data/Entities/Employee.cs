using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Data.Entities;

public partial class Employee
{
    [StringLength(15)]
    [Unicode(false)]
    public string? Account { get; set; }

    public bool? Active { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(45)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    public DateOnly? AltDateVacation { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AutoClockOut { get; set; }

    public int? AutoClockOutVariance { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Badge { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Cellphone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? City { get; set; }

    public int? Clocknumber { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CompanyId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CompanyPayrollId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CraftCode { get; set; }

    public DateOnly? DateHired { get; set; }

    public DateOnly? DateTerminated { get; set; }

    public int? Department { get; set; }

    public long? Discplcounter { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    public DateOnly? ExpDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Extension { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Foreman { get; set; }

    public bool? HolidayEligible { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Homephone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IndirectOperation { get; set; }

    public DateOnly? LastDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public int? LastTime { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? LastUser { get; set; }

    [Column("LRScreenId")]
    [StringLength(15)]
    [Unicode(false)]
    public string? LrscreenId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? MiddleInit { get; set; }

    [Column("MMHours", TypeName = "decimal(5, 2)")]
    public decimal? Mmhours { get; set; }

    [Column("MMSeq")]
    public int? Mmseq { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PayRate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PayrollFeed { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PayrollId { get; set; }

    public DateOnly? PointAccumDate { get; set; }

    [Column("SFQUsersId")]
    [StringLength(12)]
    [Unicode(false)]
    public string? SfqusersId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Shift { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ShiftSchedule { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? State { get; set; }

    public bool? Temp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TempBadge { get; set; }

    [Key]
    public int UniqueId { get; set; }

    public int? VacationAllowed { get; set; }

    public DateOnly? VacationEffDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? VacationOverride { get; set; }

    [Column(TypeName = "decimal(4, 2)")]
    public decimal? VacCarryOver { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkPhone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Zipcode { get; set; }
}
