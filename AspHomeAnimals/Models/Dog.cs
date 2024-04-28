using AspHomeAnimals.Services;

namespace AspHomeAnimals.Models
{
    public class Dog : Animal
    {
        public Dog(string name,string sound, IAnimalService animalService) : base(name, sound, animalService)
        {

        }
      
    }
}
