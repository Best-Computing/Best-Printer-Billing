using System.ComponentModel.DataAnnotations;

namespace BestPrinterBilling.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
