using Microsoft.AspNetCore.Identity;

namespace TP1.Models;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string Email { get; set; }
}