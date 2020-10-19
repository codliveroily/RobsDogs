using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ui.Entities;

namespace Ui.Data
{
    public class DogRepository : IDogRepository
    {
        public List<Dog> GetDogsByOwner(string owner)
        {
            var dogList = new List<Dog> { new Dog { Name = "Willow" }, new Dog { Name = "Nook" }, new Dog { Name = "Sox" } };
                
            return dogList;
        }
    }
}