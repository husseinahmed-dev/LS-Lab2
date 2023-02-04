using LargeSystemsLab2.Models;
using System.Threading.Tasks;

namespace LargeSystemsLab2.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
        Task<BasketModel> UpdateBasket(BasketModel model);
        Task CheckoutBasket(BasketCheckoutModel model);
    }
}
