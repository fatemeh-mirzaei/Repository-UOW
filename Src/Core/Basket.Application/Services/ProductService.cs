using Basket.Application.Common;

namespace Basket.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Product> _productRepository;
        public ProductService(IApplicationUnitOfWork unitOfWork, IGenericRepository<Product> productRepository)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
        }

        public List<GetProduct> GetAll()
        {

            List<GetProduct> getProducts = _productRepository.GetAll.Select(p => new GetProduct()
            {
                Id = p.Id,
                Title = p.Title,
                Price = p.Price,
                Stock = p.Stock

            }).ToList();


            return getProducts;
        }

        public GetProduct GetById(int Id)
        {
            var product = _productRepository.GetById(Id);

            GetProduct getProduct = new GetProduct
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price,
                Stock = product.Stock
            };

            return getProduct;
        }

        public void CreateProduct(CreateProductDto productDto)
        {
            Product product = new Product
            {
                Title = productDto.Title,
                Price = productDto.Price,
                Stock = productDto.Stock,
                Description = productDto.Description
            };

            _productRepository.Add(product);
            _unitOfWork.Commit();
        }



        public void UpdateUser(UpdateProduct productDto)
        {
            Product product = new Product
            {
                Id = productDto.Id,
                Title = productDto.Title,
                Price = productDto.Price,
                Stock = productDto.Stock,
                Description = productDto.Description
            };
            _productRepository.Update(product);
            _unitOfWork.Commit();

        }
    }
}
