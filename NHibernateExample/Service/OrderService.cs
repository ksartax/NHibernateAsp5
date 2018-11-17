using NHibernateExample.Repository.IRepository;
using NHibernateExample.Service.IService;
using NHibernateExample.ViewModel.OrderViewModel;

namespace NHibernateExample.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(OrderCreateViewModel orderCreateViewModel)
            => _orderRepository.Save(new Models.Order(orderCreateViewModel));

        public OrdersViewModel GetOrdersViewModel()
            => new OrdersViewModel(_orderRepository.GetList());
    }
}