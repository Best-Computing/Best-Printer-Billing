using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrinterBilling.Models
{
    public class MachineClientViewModel
    {
        public IEnumerable<SelectListItem> TblMachines { get; set; }
        
        public string SelectedMachineLocation { get; set; }
        public IEnumerable<SelectListItem> TblUsers { get; set; }
        public string SelectedUser { get; set; }
        public IEnumerable<SelectListItem> TblLocation { get; set; }
        public string SelectedBranch { get; set; }
    }
}
