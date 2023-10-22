using Basket.Application.Common;

namespace Basket.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<Product> _productRepository;
        public OrderService(IApplicationUnitOfWork unitOfWork, IGenericRepository<Order> orderRepository, IGenericRepository<Product> productRepository)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }
        public void CreateOrder(CreateOrderDto orderDto)
        {


            Order order = new Order
            {
                ProductId = orderDto.ProductId,
                Count = orderDto.Count,
                CreateDate = DateTime.Now,
            };

            _orderRepository.Add(order);

            Product product = _productRepository.GetById(orderDto.ProductId);
            product.Stock = product.Stock - 1;

            _productRepository.Add(product);
            _unitOfWork.Commit();



        }
    }
}
