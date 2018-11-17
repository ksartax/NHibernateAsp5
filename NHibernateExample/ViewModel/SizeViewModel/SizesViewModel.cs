using NHibernateExample.Models;
using System.Collections.Generic;

namespace NHibernateExample.ViewModel.SizeViewModel
{
    public class SizesViewModel : List<SizeViewModel>
    {
        public SizesViewModel(List<Size> sizes) : base()
        {
            sizes.ForEach(s => Add(new SizeViewModel(s)));
        }

        public SizesViewModel()
        {

        }
    }
}