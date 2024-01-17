using Microsoft.AspNetCore.Identity;

namespace Agency23.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
