using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ui.Entities;
using Ui.Data;

namespace Ui.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository _dogRepository;

        public DogService(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public List<Dog> GetDogsByOwner(string owner)
        {
            var dogList = _dogRepository.GetDogsByOwner(owner);

            return dogList;
        }
    }
}