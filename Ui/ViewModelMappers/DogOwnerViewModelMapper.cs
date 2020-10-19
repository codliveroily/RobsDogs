using System.Collections.Generic;
using System.Linq;
using Ui.Data;
using Ui.Models;
using Ui.Services;

namespace Ui.ViewModelMappers
{
    public class DogOwnerViewModelMapper : IDogOwnerViewModelMapper
    {
        private readonly IDogOwnerService _dogOwnerService;

        public DogOwnerViewModelMapper(IDogOwnerService dogOwnerService)
        {
            _dogOwnerService = dogOwnerService;
        }

        public DogOwnerListViewModel GetAllDogOwners()
        {                        
            var dogOwners = _dogOwnerService.GetAllDogOwners();
            var dogOwnerListViewModel = new DogOwnerListViewModel
            {
                DogOwnerViewModels = dogOwners.Select(e => new DogOwnerViewModel
                {
                    OwnerName = e.Name,
                    DogNames = e.Dogs.Select(o=>o.Name).ToList()
                }).ToList()
            };

            return dogOwnerListViewModel;
        }
    }
}