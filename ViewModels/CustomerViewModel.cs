using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrinterBilling.ViewModels
{
    public class CustomerViewModel
    {
        [Display(Name = "Customer Number")]
            public string UserID { get; set; }

            [Required]
            [Display(Name = "Customer Name")]
            [StringLength(75)]
            public string SelectedCustomer { get; set; }
            public IEnumerable<SelectListItem> TblUsers { get; set; }

            [Required]
            [Display(Name = "Branch")]
            public string SelectedBranch { get; set; }
            public IEnumerable<SelectListItem> TblLocation { get; set; }

           
            public string SelectUsersMachine { get; set; }
            public IEnumerable<SelectListItem> TblUsersMachine { get; set; }
        
    }
}
