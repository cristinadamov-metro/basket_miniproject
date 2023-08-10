// saved in db; a basket has many articles, save creation date;

using Basket.CustomerDomain;

namespace Basket.BasketDomain
{
    public class Basket
    {
        public Guid Id { get; set; }
        public List<ArticleLine> ArticleLines { get; set; }
        public DateTime CreationDate { get; set; }
        
    }
}
