using Microsoft.AspNetCore.Identity;

namespace gloryhall.Data.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}