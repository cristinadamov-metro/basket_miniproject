namespace Basket.ArticleDomain
{
    public interface IArticleService
    {
        Task AddItem(Article article);
        Task<Article> FindItem(string name);

    }
}
