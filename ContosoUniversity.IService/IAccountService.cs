using ContosoUniversity.Data;
using ContosoUniversity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ContosoUniversity.IService
{
    public interface IAccountService
    {
        Task<IdentityUser> GetUserAsync(string account, string password, ApplicationContext context);
    }
}
