using Microsoft.AspNetCore.Identity;

namespace TechSurvey.Entity.Concrete
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IList<IdentityRole>? Roles { get; set; }
    }
}
