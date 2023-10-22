namespace Basket.Domain
{
    public class Order : IBaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Product Product { get; set; }

    }
}
