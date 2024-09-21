namespace PaceIndustries.Supplier.Models.PurchaseOrder
{
    public class PurchaseOrderItemDetails
    {
        public int Ponumber { get; set; }
        public int Poitem { get; set; }
        public int OrderNumber { get; set; }
        public decimal OrderQty { get; set; }
        public decimal POItemRecvQty { get; set; }
        public decimal ReturnQty { get; set; }
        public bool POItemComplete { get; set; }
        public string UnitMeas { get; set; }
        public string? MatlDesc1 { get; set; }
        public string? MaterialId { get; set; }
        public string? Requester { get; set; }
        public DateTime POItemUpdateTimeStamp { get; set; }
        public List<PurchaseOrderDateDetails> Dates { get; set; } = new List<PurchaseOrderDateDetails>();
    }
}
