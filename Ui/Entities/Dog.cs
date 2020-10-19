namespace Ui.Entities
{    
    public class Dog : Animal
    {        
        public virtual DogOwner Owner { get; set; }
    }
}