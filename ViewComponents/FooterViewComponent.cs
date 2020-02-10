using Microsoft.AspNetCore.Mvc;

namespace BestPrinterBilling.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        public FooterViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
