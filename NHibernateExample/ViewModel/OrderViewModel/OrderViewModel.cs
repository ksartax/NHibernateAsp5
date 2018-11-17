using NHibernateExample.Models;

namespace NHibernateExample.ViewModel.OrderViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }

        public ProductViewModel.ProductsViewModel Products { get; set; }
        public UserViewModel User { get; set; }

        public OrderViewModel()
        {
        }

        public OrderViewModel(Order order)
        {
            Id = order.Id;
            TotalPrice = order.TotalPrice;
        }
    }
}