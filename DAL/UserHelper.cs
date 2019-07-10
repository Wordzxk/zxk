using System;
using System.Data;

namespace DAL
{
    public class UserHelper
    {
        private static DataTable _users = new DataTable();
        /// <summary>
        /// 在持久层（数据库）中查找用户名以获取用户Id
        /// </summary>
        /// <param name="ustrname">用户名</param>
        /// <returns>如果找到，返回用户Id；否则返回null</returns>
        public int? GetByName(string ustrname)
        {
            return null;
        }
        //加入仓库
        public void Save (string name, string password)
        {

        }
    }
}
