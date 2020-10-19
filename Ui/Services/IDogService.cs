using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ui.Entities;

namespace Ui.Services
{
    public interface IDogService
    {
        List<Dog> GetDogsByOwner(string owner);
    }
}
