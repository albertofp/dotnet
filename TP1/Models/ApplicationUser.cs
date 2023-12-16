using Microsoft.AspNetCore.Identity;

namespace TP1.Models;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public override string Email { get; set; }
    [PersonalData]
    public string Password { get; set; }
}