using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TVManagerDAL;

namespace TVManagerBLL
{
    /// <summary>
    /// 业务逻辑类
    /// </summary>
    public class TvBLL
    {
        /// <summary>
        /// 显示数据
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader TvShowBLL()
        {
            return TvDAL.TvShowDAL();
        }


        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader TvDimBLL(string tvnmae)
        {
            return TvDAL.TvDimDAL(tvnmae);
        }

        }
}
