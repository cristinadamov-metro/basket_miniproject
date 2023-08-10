namespace Basket.CustomerDomain
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(Customer customer);
    }
}
