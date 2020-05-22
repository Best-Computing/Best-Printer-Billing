using BestPrinterBilling.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrinterBilling.ViewModels
{
    public class MachineClientViewModel
    {

        public TblLocation TblLocation { get; set; }

        public string SelectedCustomer { get; set; }
        public TblUsers TblUsers { get; set; }
        public TblUsersmachine TblUsersmachine { get; set; }
        public TblMachine TblMachine {get;set;}


 //       public IEnumerable<SelectListItem> TblUsersMachine { get; set; }
        
     //   public string SelectedMachineLocation { get; set; }
   //     public IEnumerable<SelectListItem> TblUsers { get; set; }
     //   public string SelectedUser { get; set; }
      //  public IEnumerable<SelectListItem> TblLocation { get; set; }
       // public string SelectedBranch { get; set; }
    }
}
