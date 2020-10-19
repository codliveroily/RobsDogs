using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ui.Entities
{
    public class Animal : IAnimal
    {
        [Key]
        public string Name { get; set; }
    }
}