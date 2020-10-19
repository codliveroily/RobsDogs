using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ui.Entities;

namespace Ui.Data
{
    public interface IDogRepository
    {
        List<Dog> GetDogsByOwner(string owner);
    }
}
