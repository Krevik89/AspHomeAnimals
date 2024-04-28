using System.IO;
using AspHomeAnimals.Models;
using AspHomeAnimals.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspHomeAnimals.Pages
{
    
    public class AnimalInfoModel : PageModel
    {
        private readonly IAnimalService _animalService;

        public Animal? Animal { get; set; }

        public AnimalInfoModel()
        {
            _animalService = new AnimalService();

        }
        
        public void OnGet(string name, string sound)
        {
            
            if (name == "Кот")
            {
                Animal = new Cat(name, sound, _animalService);
            }
            else
            {
                Animal = new Dog(name, sound, _animalService);
            }
           
            if (Animal == null)
            {
                throw new ArgumentNullException(nameof(Animal), "Animal object is null.");
            }
            
        }

        public IActionResult OnPost(string name,string sound)
        {        
            Animal anim = new Cat(name, sound, _animalService);
            string filePath = "animal_info.txt";
            
                anim.SaveToFile(filePath);

                return RedirectToPage("/Error");
         
        }
    }
}
