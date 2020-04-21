using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.Account
{
    public class LoginViewModel
    {
        #region Attribute

        /// <summary>
        /// 帐户名
        /// </summary>
        [Required(ErrorMessage = "登录名不能为空")]
        [Display(Name = "登录名")]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 是否记住帐户名
        /// </summary>
        [Display(Name = "记住登录名")]
        public bool RememberMe { get; set; }

        #endregion
    }
}
