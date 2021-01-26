using System;

namespace SeedAPI.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }
    }
}
