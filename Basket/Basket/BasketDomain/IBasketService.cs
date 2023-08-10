namespace Basket.BasketDomain
{
    public interface IBasketService
    {
        Task<Guid> Add();
        Task<Guid> AddArticleLine(Guid basketId, ArticleLineSaveDto dto);
        Task<Basket?> Get(Guid id);
    }
}
