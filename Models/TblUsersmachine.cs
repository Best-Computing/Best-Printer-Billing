using System;
using System.Collections.Generic;

namespace BestPrinterBilling.Models
{
    public partial class TblUsersmachine
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
    }
}
