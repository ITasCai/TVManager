using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TVManagerCommon;

namespace TVManagerDAL
{
    /// <summary>
    /// 数据访问类
    /// </summary>
    public class TvDAL
    {

        /// <summary>
        /// 显示数据
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader TvShowDAL() {
            string str = "SELECT c.CName,t.TName,t.StartTime FROM dbo.Channel c,dbo.TVReport t WHERE t.CId=c.CId ";

            SqlDataReader sdr = SqlHelper.GetDateReader(CommandType.Text,str,null);
            return sdr;
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader TvDimDAL(string tvnmae)
        {
            string str = string.Format(" SELECT c.CName,t.TName,t.StartTime FROM dbo.Channel c,dbo.TVReport t WHERE t.CId=c.CId AND  t.TName LIKE '%{0}%'",tvnmae);

            SqlDataReader sdr = SqlHelper.GetDateReader(CommandType.Text,str ,null);
            return sdr;
        }
        }
}
