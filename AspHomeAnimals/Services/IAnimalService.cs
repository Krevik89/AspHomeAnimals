using AspHomeAnimals.Models;

namespace AspHomeAnimals.Services
{
    public interface IAnimalService
    {
        string DisplayAnimalInfo(Animal animal);
        void SaveAnimalToFile(Animal animal, string filePath);
    }
}
