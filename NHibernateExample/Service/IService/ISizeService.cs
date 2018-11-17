using NHibernateExample.Service.IService.Helper;
using NHibernateExample.ViewModel.SizeViewModel;
using System.Web.Mvc;

namespace NHibernateExample.Service.IService
{
    public interface ISizeService : ISelectList
    {
        void Add(SizeCreateViewModel sizeCreateViewModel);

        SizesViewModel GetSizesViewModel();

        new SelectList GetSelectList();
    }
}
