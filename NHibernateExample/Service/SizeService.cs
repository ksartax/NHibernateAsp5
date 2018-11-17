using NHibernateExample.Service.IService;
using NHibernateExample.Repository.IRepository;
using NHibernateExample.ViewModel.SizeViewModel;
using System.Web.Mvc;

namespace NHibernateExample.Service
{
    public class SizeService : ISizeService
    {
        private readonly ISizeRepository _sizeRepository;

        public SizeService(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public void Add(SizeCreateViewModel sizeCreateViewModel) 
            => _sizeRepository.Save(new Models.Size(sizeCreateViewModel));

        public SizesViewModel GetSizesViewModel() 
            => new SizesViewModel(_sizeRepository.GetList());

        public SelectList GetSelectList()
            => new SelectList(_sizeRepository.GetList(), "Id", "Number");
    }
}