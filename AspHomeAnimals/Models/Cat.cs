using AspHomeAnimals.Services;
namespace AspHomeAnimals.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string sound, IAnimalService animalService) : base(name, sound, animalService) { }
    }
}
