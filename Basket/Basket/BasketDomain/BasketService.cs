using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Basket.BasketDomain
{
    public class BasketService : IBasketService
    {
        BasketContext _context;
        public BasketService(BasketContext context)
        {
            _context = context;
        }

        public async Task<Guid> Add()
        {
            var entity = new Basket
            {
                Id = Guid.NewGuid(),
                ArticleLines = new List<ArticleLine>(),
                CreationDate = DateTime.UtcNow

            };
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<Guid> AddArticleLine(Guid basketId, ArticleLineSaveDto dto)
        {
            var entity = new ArticleLine
            {
                Id = Guid.NewGuid() ,
                BasketId = basketId,
                ArticleId = dto.ArticleId,
                Quantity = dto.Quantity
            };
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }


        public async Task<Basket?> Get(Guid id)
        {
            var articleLines = _context.ArticleLines.Where(a => a.BasketId == id).ToList();
            var basket = await _context.Baskets.Where(a => a.Id == id).SingleOrDefaultAsync();
            basket.ArticleLines = articleLines;
            return basket;
        }
    }
}
