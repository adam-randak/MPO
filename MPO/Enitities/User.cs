using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Entities
{
    public class User: IdentityUser
    {
        /*
        public string UserName { get; set; }
        */
        
        public string Password { get; set; }

    }
}
