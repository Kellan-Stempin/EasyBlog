using Microsoft.AspNetCore.Identity;

namespace EasyBlog.Models
{
    // inherits everything from IdentityUser: Id, Email, Password, etc.
    public class UserApp : IdentityUser
    {
        // can add custom properties here
        // ex: public string DisplayName { get; set; }
    }
}
