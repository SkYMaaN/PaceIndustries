namespace PaceIndustries.Shared.Models.PurchaseOrder
{
    public class PurchaseOrderDetails
    {
        public long? OdyUniqueId { get; set; }

        public int Ponumber { get; set; }
        public DateTime PoDate { get; set; }
        public string? CompanyId { get; set; }
        public string? PurchAgent { get; set; }
        public string CurrCode { get; set; }
        public string Termcode { get; set; }
        public string Ackstatus { get; set; }
        public bool POClosed { get; set; }
        public DateTime POHeaderUpdateTimeStamp { get; set; }
        public List<PurchaseOrderItemDetails> Items { get; set; } = new List<PurchaseOrderItemDetails>();
    }
}
