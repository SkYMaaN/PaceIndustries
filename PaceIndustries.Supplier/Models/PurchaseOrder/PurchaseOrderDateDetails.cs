namespace PaceIndustries.Supplier.Models.PurchaseOrder
{
    public class PurchaseOrderDateDetails
    {
        public int RelNum { get; set; }
        public DateTime PromiseDate { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal RequestQty { get; set; }
        public decimal PODateRecvQty { get; set; }
        public bool PODateComplete { get; set; }
        public DateTime PODateUpdateTimeStamp { get; set; }
    }
}
