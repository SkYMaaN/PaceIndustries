using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("qwsOpportunity_List")]
public partial class QwsOpportunityList
{
    [StringLength(255)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MarketSegment { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("Status_Title")]
    [StringLength(255)]
    [Unicode(false)]
    public string? StatusTitle { get; set; }

    [Column(TypeName = "text")]
    public string? Notes { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ProgressValue { get; set; }

    [Column("MarketSegment_ID")]
    public int? MarketSegmentId { get; set; }

    [Column("MarketSegment_ID_Title")]
    [StringLength(255)]
    [Unicode(false)]
    public string? MarketSegmentIdTitle { get; set; }

    [Column("In_Salesforce")]
    public bool? InSalesforce { get; set; }

    [Column("Salesforce_Link")]
    [StringLength(255)]
    [Unicode(false)]
    public string? SalesforceLink { get; set; }

    public bool? TestingOnly { get; set; }

    [Column("SalesForce_RFQ_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SalesForceRfqId { get; set; }

    [Column("SF_Opportunity_Type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SfOpportunityType { get; set; }

    [Column("SF_Stage")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SfStage { get; set; }

    [Column("SF_MarketStack")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SfMarketStack { get; set; }

    [Column("SF_Plant")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SfPlant { get; set; }

    [Key]
    [Column("ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("SF_CloseDate")]
    public DateOnly? SfCloseDate { get; set; }

    [Column("SF_Created_Date")]
    public DateOnly? SfCreatedDate { get; set; }

    [Column("Account_Manager_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AccountManagerId { get; set; }

    [Column("Customer_SF_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CustomerSfId { get; set; }

    [Column("SF_Conf_Level")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SfConfLevel { get; set; }

    [Column("SF_Cust_Stage")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SfCustStage { get; set; }

    [Column("RowID")]
    public int RowId { get; set; }
}
