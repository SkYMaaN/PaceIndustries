using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PaceIndustries.Shared.Data.Entities;

[Table("ProductionHistory")]
public partial class ProductionHistory
{
    public long Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CompanyId { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Account { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Actfovh { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Actlabr { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Actvovh { get; set; }

    public bool? AddtoBox { get; set; }

    [Column("AdjStartAP")]
    [StringLength(2)]
    [Unicode(false)]
    public string? AdjStartAp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdjStartDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AdjStartTime { get; set; }

    [Column("AdjStopAP")]
    [StringLength(2)]
    [Unicode(false)]
    public string? AdjStopAp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdjStopDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AdjStopTime { get; set; }

    public bool? Adjustment { get; set; }

    public bool? AfterRecipeRelief { get; set; }

    public bool? AutoAllocated { get; set; }

    public bool? AutoAllocatedProd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AutoAllocProdMeth { get; set; }

    public bool? AutoCrewOut { get; set; }

    [Column("AutoDT")]
    public bool? AutoDt { get; set; }

    public bool? AutoMoldPour { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Badge { get; set; }

    public int? BookQty { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? BreakTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BudgetCode { get; set; }

    public bool? ByToolParent { get; set; }

    public int? CalculatedShots { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CastDate { get; set; }

    public int? Cellcount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Chgflag { get; set; }

    [Column("CITran")]
    public bool? Citran { get; set; }

    [Column("CITranType")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CitranType { get; set; }

    public int? Clocknumber { get; set; }

    public bool? Compgen { get; set; }

    public bool? Complete { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? CompPrice { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Config { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ConsLocType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ConsType { get; set; }

    [Column("ContainerID")]
    public int? ContainerId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CostFlag { get; set; }

    [Column("CreateWO")]
    public bool? CreateWo { get; set; }

    public bool? Crew { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CrewCode { get; set; }

    public int? CrewCount { get; set; }

    public int? CrewLeader { get; set; }

    public bool? Crewmember { get; set; }

    public bool? CustomerRework { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public int? Department { get; set; }

    public int? Division { get; set; }

    [Column("DTTime", TypeName = "decimal(10, 2)")]
    public decimal? Dttime { get; set; }

    public int? Effqty { get; set; }

    public int? Elapsedmanminutes { get; set; }

    public int? ElapsedMin { get; set; }

    public int? EndingShots { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? Equipment { get; set; }

    [Column("ExportLogID")]
    public int? ExportLogId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ExportStatus { get; set; }

    public int? Familymolds { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Foreman { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FromLocation { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? FromSerialNumber { get; set; }

    public int? FromTrackingnumber { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? FrozenStdCost { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Frozfovh { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Frozlabr { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? Frozvovh { get; set; }

    [Column("GenContainerID")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GenContainerId { get; set; }

    [Column("GL05JV")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Gl05jv { get; set; }

    [Column("GLPosted")]
    public bool? Glposted { get; set; }

    [Column("GrandParentID")]
    public int? GrandParentId { get; set; }

    [Column(TypeName = "decimal(16, 5)")]
    public decimal? GrossWgt { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Groupcode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Heatnumber { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? HeatTreat { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Hours { get; set; }

    public bool? HrPunch { get; set; }

    public int? InspectBy { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? InspectStatus { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? InterFaceFlag { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? InvAffected { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InvLocation { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? JobNumber { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    public bool? LunchPunch { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LunchTime { get; set; }

    [Column(TypeName = "decimal(13, 5)")]
    public decimal? Manbreakhours { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Mandowntime { get; set; }

    [Column(TypeName = "decimal(13, 5)")]
    public decimal? Manhours { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Manlunchhours { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? Manrate { get; set; }

    [Column("MasterContID")]
    public int? MasterContId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MoldBreakTime { get; set; }

    [Column("MoldDTTime", TypeName = "decimal(10, 2)")]
    public decimal? MoldDttime { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MoldHours { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MoldLunchTime { get; set; }

    public int? MoldsMade { get; set; }

    public int? MoldsNotPoured { get; set; }

    public int? MoldsPoured { get; set; }

    [Column("MoldStopAP")]
    [StringLength(2)]
    [Unicode(false)]
    public string? MoldStopAp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MoldStopDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? MoldStopTime { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? MoldStopTimeDec { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Mtype { get; set; }

    public bool? MultiSerial { get; set; }

    [Column(TypeName = "decimal(16, 5)")]
    public decimal? Netwgt { get; set; }

    public int? NewContQty { get; set; }

    public int? Numbermachines { get; set; }

    public int? Numberon { get; set; }

    public long? NumOfBoxes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Operation { get; set; }

    [Column("OPkgcode")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Opkgcode { get; set; }

    public int? Orderitem { get; set; }

    public int? Ordernumber { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Ordertype { get; set; }

    public int? ParentEffqty { get; set; }

    [Column("ParentID")]
    public long? ParentId { get; set; }

    public int? ParentQty { get; set; }

    public int? ParentShots { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? PayDollars { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PayDollarType { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PayHours { get; set; }

    public int? PayMinutes { get; set; }

    public bool? PayOvrd { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? PayOvrdBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayOvrdDate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PayOvrdRsn { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? PayRate { get; set; }

    public int? PickListNbr { get; set; }

    public int? PiecesPerBox { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Pkgcode { get; set; }

    [Column("PMnumber")]
    public int? Pmnumber { get; set; }

    public int? PostPeriod { get; set; }

    public int? PostYear { get; set; }

    [Column("ProdID")]
    public int? ProdId { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    public bool? ProductionInterface { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ProductType { get; set; }

    [Column("PSNumber")]
    public int? Psnumber { get; set; }

    [Column("PSRtgseq")]
    public int? Psrtgseq { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PunchElapsedTime { get; set; }

    [Column("PunchStartAP")]
    [StringLength(2)]
    [Unicode(false)]
    public string? PunchStartAp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PunchStartDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PunchStartTime { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? PunchStartTimeDec { get; set; }

    [Column("PunchStopAP")]
    [StringLength(2)]
    [Unicode(false)]
    public string? PunchStopAp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PunchStopDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PunchStopTime { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? PunchStopTimeDec { get; set; }

    public bool? PurchasedCasting { get; set; }

    public int? Qty { get; set; }

    [Column("RCSerialNbr")]
    [StringLength(25)]
    [Unicode(false)]
    public string? RcserialNbr { get; set; }

    [Column(TypeName = "decimal(26, 9)")]
    public decimal? Reading { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Reasoncode { get; set; }

    public bool? RecipeRelief { get; set; }

    public int? Relnumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ReportSeries { get; set; }

    public bool? ReturnCode { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? ReturnDollars { get; set; }

    public bool? ReworkRtg { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReworkRtgCode { get; set; }

    [Column("RMAAutoCreated")]
    public bool? RmaautoCreated { get; set; }

    [Column("RMAItem")]
    public int? Rmaitem { get; set; }

    [Column("RMANumber")]
    public int? Rmanumber { get; set; }

    [Column("RMAType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Rmatype { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RtgCode { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? RtgRate { get; set; }

    public int? RtgSeq { get; set; }

    [Column("RtgSeqID")]
    public int? RtgSeqId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? RunNumber { get; set; }

    public bool? Sample { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SampleType { get; set; }

    [Column(TypeName = "decimal(16, 5)")]
    public decimal? SampleWeight { get; set; }

    [Column(TypeName = "decimal(16, 5)")]
    public decimal? SampleWgtEa { get; set; }

    public bool? SampleWgtVariance { get; set; }

    [Column("SampleWQty")]
    public int? SampleWqty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ScrapOperation { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ScrappedAt { get; set; }

    public int? ScrapSeq { get; set; }

    [Column("ScreenID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ScreenId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SerialLevel { get; set; }

    public int? SerialNumLen { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? SerialPrefix { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? SerialSuffix { get; set; }

    public bool? Setup { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Shift { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ShiftSchedule { get; set; }

    [Column("ShipmentID")]
    public int? ShipmentId { get; set; }

    public int? ShipWgt { get; set; }

    public int? Shots { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Source { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? StageMethod { get; set; }

    public bool? Staging { get; set; }

    public int? StartingShots { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? StartTime { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? StdCost { get; set; }

    [Column("StdFGCost", TypeName = "decimal(18, 5)")]
    public decimal? StdFgcost { get; set; }

    [Column(TypeName = "decimal(20, 5)")]
    public decimal? StdFovh { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? StdHours { get; set; }

    [Key]
    public long OdyUniqueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateTimeStamp { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProductionHistories")]
    public virtual Plant Company { get; set; } = null!;

    [ForeignKey("Product, CompanyId")]
    [InverseProperty("ProductionHistories")]
    public virtual Product ProductNavigation { get; set; } = null!;
}
