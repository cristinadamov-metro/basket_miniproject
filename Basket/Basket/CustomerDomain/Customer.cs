namespace Basket.CustomerDomain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool PayVat { get; set; }
        public DateTime CreationDate { get; set; }
        public string CUI { get; set; }
        public string Address { get; set; }
        public BasketDomain.Basket? Basket { get; set; }
    }
}
