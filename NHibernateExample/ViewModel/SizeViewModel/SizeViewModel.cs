using NHibernateExample.Models;

namespace NHibernateExample.ViewModel.SizeViewModel
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public SizeViewModel()
        {
        }

        public SizeViewModel(Size size)
        {
            Id = size.Id;
            Number = size.Number;
        }
    }
}