using AspHomeAnimals.Services;
namespace AspHomeAnimals.Models
{
    public class Animal 
    {
        public string? Name { get; set; }
        public string? Sound { get; set; }

        private readonly IAnimalService AnimalService;

        public Animal(string name, string sound, IAnimalService animalService)
        {
            Name = name;
            Sound = sound;
            AnimalService = animalService;
        }

        public virtual string DisplayInfo()
        {
            return AnimalService.DisplayAnimalInfo(this);
        }

        public virtual void SaveToFile(string filePath)
        {
            AnimalService.SaveAnimalToFile(this, filePath);
            
        }
    }
}
