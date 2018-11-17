using NHibernateExample.Models;
using System.Collections.Generic;

namespace NHibernateExample.ViewModel.OrderViewModel
{
    public class OrdersViewModel : List<OrderViewModel>
    {
        public OrdersViewModel(List<Order> orders) : base()
        {
            orders.ForEach(s => Add(new OrderViewModel(s)));
        }
    }
}