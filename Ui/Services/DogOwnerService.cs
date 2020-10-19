using System.Collections.Generic;
using Ui.Data;
using Ui.Entities;

namespace Ui.Services
{
    public class DogOwnerService : IDogOwnerService
    {
        private readonly IDogOwnerRepository _dogOwnerRepository;
        private readonly IDogService _dogService;
        public DogOwnerService(IDogOwnerRepository dogOwnerRepository, IDogService dogService)
        {
            _dogOwnerRepository = dogOwnerRepository;
            _dogService = dogService;
        }

        public List<DogOwner> GetAllDogOwners()
        {            
            var dogOwnerList = _dogOwnerRepository.GetAllDogOwners();
            foreach(var dogOwner in dogOwnerList)
            {
                var dogs = _dogService.GetDogsByOwner(dogOwner.Name);
                dogOwner.Dogs = dogs;
            }

            return dogOwnerList;
        }
    }
}