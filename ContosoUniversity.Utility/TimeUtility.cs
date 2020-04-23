﻿using System;

namespace ContosoUniversity.Utility
{
    public class TimeUtility
    {
        #region Service

        /// <summary>
        /// 获取当前日期时间
        /// </summary>
        /// <param name="hasTime">是否包含时间</param>
        /// <returns></returns>
        public static DateTime Format(bool hasTime = false)
        {
            return hasTime == true ? Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) : Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
        }

        /// <summary>
        /// 获取当前时间的序列
        /// </summary>
        /// <returns></returns>
        public static long GetTimespans()
        {
            return Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmss"));
        }

        #endregion
    }
}
