namespace Basket.Application.Interfaces
{
    public interface IProductService
    {
        public List<GetProduct> GetAll();
        public GetProduct GetById(int Id);
        public void CreateProduct(CreateProductDto productDto);
        public void UpdateUser(UpdateProduct productDto);

    }
}
