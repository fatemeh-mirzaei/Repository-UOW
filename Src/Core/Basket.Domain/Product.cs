namespace Basket.Domain
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
