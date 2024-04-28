using AspHomeAnimals.Models;

namespace AspHomeAnimals.Services
{
    public class AnimalService : IAnimalService
    {
        public string DisplayAnimalInfo(Animal animal)
        {
            return animal.DisplayInfo();
        }

        public void SaveAnimalToFile(Animal animal, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(animal.Name);
                writer.WriteLine(animal.Sound);
            }
        }
    }
}
