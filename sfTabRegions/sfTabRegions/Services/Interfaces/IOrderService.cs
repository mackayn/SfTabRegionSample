using System.Threading.Tasks;

namespace sfTabRegions.Services.Interfaces
{
    public interface IOrderService
    {
        Task<string> GetLastOrderDescription();
    }
}
