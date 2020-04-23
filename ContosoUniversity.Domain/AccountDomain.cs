using ContosoUniversity.Data;
using ContosoUniversity.Entity;
using ContosoUniversity.IService;
using ContosoUniversity.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Domain
{
    public class AccountDomain:IAccountService
    {
        public async Task<IdentityUser> GetUserAsync(string account, string password, ApplicationContext context)
        {
            return await CURepository.GetUserAsync(account, context);
        }
    }
}
