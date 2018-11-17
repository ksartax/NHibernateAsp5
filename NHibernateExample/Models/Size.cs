using NHibernateExample.ViewModel.SizeViewModel;
using System.Collections.Generic;

namespace NHibernateExample.Models
{
    public class Size
    {
        public virtual int Id { get; set; }
        public virtual int Number { get; set; }

        public virtual IList<Product> Products { get; set; }

        public Size()
        {
        }

        public Size(SizeCreateViewModel sizeCreateViewModel)
        {
            Number = sizeCreateViewModel.Number;
        }
    }
}