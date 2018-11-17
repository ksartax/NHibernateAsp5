using NHibernateExample.ViewModel.OrderViewModel;
using System.Collections.Generic;

namespace NHibernateExample.Models
{
    public class Order
    {
        public virtual int Id { get; set; }
        public virtual float TotalPrice { get; set; }

        public virtual User User { get; set; }

        public virtual IList<Product> Products { get; set; }

        public Order()
        {
        }

        public Order(OrderCreateViewModel orderCreateViewModel)
        {
            TotalPrice = orderCreateViewModel.TotalPrice;
        }
    }
}