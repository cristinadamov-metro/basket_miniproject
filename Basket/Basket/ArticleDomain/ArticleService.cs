using Microsoft.EntityFrameworkCore;

namespace Basket.ArticleDomain
{

    public class ArticleService : IArticleService
    {
        public ArticleService(BasketContext basketContext)
        {

            _basketContext = basketContext;
        }
        BasketContext _basketContext { get; set; }

        public async Task AddItem(Article article)
        {
            await _basketContext.AddAsync(article);
            await _basketContext.SaveChangesAsync();
        }

        public async Task<Article> FindItem(string name)
        {
            return await _basketContext.Articles.Where(a => a.Name.Contains(name)).FirstAsync();
        }
    }
}
