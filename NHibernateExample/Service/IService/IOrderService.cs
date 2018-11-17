using NHibernateExample.ViewModel.OrderViewModel;

namespace NHibernateExample.Service.IService
{
    public interface IOrderService
    {
        OrdersViewModel GetOrdersViewModel();
        void Add(OrderCreateViewModel ordersCreateViewModel);
    }
}
