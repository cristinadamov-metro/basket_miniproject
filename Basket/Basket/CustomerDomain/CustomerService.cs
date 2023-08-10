using Microsoft.AspNetCore.Authentication;

namespace Basket.CustomerDomain
{
    public class CustomerService : ICustomerService
    {
        BasketContext _basketContext;

        public CustomerService(BasketContext basketContext)
        {
            _basketContext = basketContext;
        }
        public async Task AddCustomerAsync(Customer customer)
        {
            var entity = new Customer
            {
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
            };

            await _basketContext.AddAsync(entity);
            await _basketContext.SaveChangesAsync();


        }
    }
}
