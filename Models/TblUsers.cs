using System;
using System.Collections.Generic;

namespace BestPrinterBilling.Models
{
    public partial class TblUsers
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public bool? Isadmin { get; set; }
    }
}
