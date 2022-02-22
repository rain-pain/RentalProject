using Microsoft.AspNetCore.Identity;

namespace RentalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Car> Cars { get; set; } 
    }
}
