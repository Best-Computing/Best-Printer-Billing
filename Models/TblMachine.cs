using System;
using System.Collections.Generic;

namespace BestPrinterBilling.Models
{
    public partial class TblMachine
    {
        public int MachineId { get; set; }
        public string Serialnum { get; set; }
        public string Devicemodel { get; set; }
        public int UserId { get; set; }
        public double PriceBw { get; set; }
        public double PriceClr { get; set; }
        public double PriceClrlrg { get; set; }
        public int PrevRdsBw { get; set; }
        public int PrevRdsClr { get; set; }
        public int PrevRdsClrlrg { get; set; }
        public int CurRdsBw { get; set; }
        public int CurRdsClr { get; set; }
        public int CurRdsClrlrg { get; set; }
        public int QtyBw { get; set; }
        public int QtyClr { get; set; }
        public int QtyClrlrg { get; set; }
        public string PrevInvoiceId { get; set; }
        public double PrevInvoiceTotal { get; set; }
        public string CurInvoiceId { get; set; }
        public double CurInvoiceTotal { get; set; }
        public string Status { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public string CollectionMethod { get; set; }
        public string Location { get; set; }
        public string MinCharge { get; set; }
        public bool? IsActive { get; set; }
        public string PrintCountBw { get; set; }
        public string PrintCountColor { get; set; }
        public string PrintCountLarge { get; set; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public string ContactPerson { get; set; }
    }
}
