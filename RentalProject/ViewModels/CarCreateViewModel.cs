using RentalProject.Models;
using System.ComponentModel;

namespace RentalProject.ViewModels
{
    public class CarCreateViewModel
    {
        public int Id { get; set; }
        [DisplayName("Модель")]
        public string Model { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        [DisplayName("Картинка")]
        public IFormFile Image { get; set; }
        public ApplicationUser Buyer { get; set; }
    }
}
