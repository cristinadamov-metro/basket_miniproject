using Basket.ArticleDomain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Basket.BasketDomain
{
    public class ArticleLine
    {
        public Guid Id { get; set; }
        public Article Article { get; set; }
        public Basket Basket { get; set; }
        public int Quantity { get; set; }
        public Guid ArticleId { get; set; }
        public Guid BasketId { get; set; }
    }
}
