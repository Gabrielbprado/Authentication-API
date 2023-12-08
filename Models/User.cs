using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace Authentication_API.Models;

public class User : IdentityUser
{
    public DateTime DateBirth { get; set; }
    public User() : base() 
    {
        
    }
}
