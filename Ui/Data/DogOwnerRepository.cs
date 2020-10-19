﻿using System.Collections.Generic;
using Ui.Entities;

namespace Ui.Data
{
    public class DogOwnerRepository : IDogOwnerRepository
    {
        public List<DogOwner> GetAllDogOwners()
        {
            var dogOwnerList = new List<DogOwner>
            {
                new DogOwner
                {
                    Name = "Rob"
                }
            };

            return dogOwnerList;
        }
    }
}