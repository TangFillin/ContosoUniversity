using ContosoUniversity.Data;
using ContosoUniversity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Repository
{
    public class CURepository
    {
        /// <summary>
        /// 获取登录账户信息
        /// </summary>
        /// <param name="account">帐户名</param>
        /// <param name="context">数据库上下文对象</param>
        /// <returns></returns>
        public static async Task<IdentityUser> GetUserAsync(string account, ApplicationContext context)
        {
            return await context.IdentityUser.AsNoTracking().Where(i => i.Account == account && i.IsEnabled == true).FirstOrDefaultAsync();
        }
    }
}
