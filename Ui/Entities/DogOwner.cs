using System.Collections.Generic;

namespace Ui.Entities
{
	public class DogOwner
	{
		public DogOwner()
		{
			Dogs = new List<Dog>();
		}
		public string Name { get; set; }

		public virtual List<Dog> Dogs { get; set; }		
	}
}