using System.Threading.Tasks;

namespace BestPrinterBilling.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
