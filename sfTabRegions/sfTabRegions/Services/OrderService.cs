using System.Threading.Tasks;
using sfTabRegions.Services.Interfaces;

namespace sfTabRegions.Services
{
    public class OrderService : IOrderService
    {
        public async Task<string> GetLastOrderDescription()
        {
            await Task.Delay(3000);
            return "You last order was a 997 Sport classic. Very nice.";
        }
    }
}
