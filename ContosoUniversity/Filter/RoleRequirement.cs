using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Filter
{
    public class RoleRequirement:IAuthorizationRequirement
    {
        public string Role { get; private set; }
        public RoleRequirement(string role)
        {
            this.Role = role;
        }
    }
}
