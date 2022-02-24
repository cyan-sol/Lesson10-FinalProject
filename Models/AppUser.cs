using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Lesson10_FinalProject.Models{
    public class AppUser : IdentityUser {
        public IEnumerable<Post> Posts {get;set;}
    }
}