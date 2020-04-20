using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrinterBilling.Models
{
    public class MachineClientViewModel
    {
        public List<TblMachine> allMachines { get; set; }
        public List<TblUsers> allUsers { get; set; }

        public List<TblLocation> allLocations { get; set; }

    }
}
