using ContosoUniversity.Utility;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Entity
{
    public class IdentityUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public string IdentityUserOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public long Id { get; set; } = TimeUtility.GetTimespans();

        /// <summary>
        /// 用户姓名
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 帐户名
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Account { get; set; }
        /// 密码
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 加密参数
        /// </summary>
        [Required]
        public string Salt { get; set; }
        /// <summary>
        /// 账户类型
        /// 0：管理员账户；1：教职工账户；2：学生用户
        /// </summary>
        [Required]
        public short AccountType { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [Required]
        public bool IsEnabled { get; set; }
    }
}
