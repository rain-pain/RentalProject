using System.ComponentModel;

namespace RentalProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        [DisplayName("Модель")]
        public string Model { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        [DisplayName("Картинка")]
        public string ImagePath { get; set; }
        public ApplicationUser Buyer { get; set; }
        public string BuyerId   { get; set; }

    }
}
    