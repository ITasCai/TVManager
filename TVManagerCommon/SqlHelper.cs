using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TVManagerCommon
{
    // <summary>
    /// 静态帮助类
    /// </summary>
    public class SqlHelper
    {
        public static readonly string strcon = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        public static readonly string Dbowner = ConfigurationManager.ConnectionStrings["DataBaseOwmer"].ConnectionString;


        /// <summary>
        /// 使用DataReader 查询多条记录
        /// </summary>
        /// <param name="cmdtype">命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递参数</param>
        /// <returns></returns>
        public static SqlDataReader GetDateReader(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {

            //实例化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);

            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.CommandType = cmdtype;
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 查询结果集
        /// </summary>
        /// <param name="cmdtype">命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递参数</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            //初始化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.CommandType = cmdtype;
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                //创建一个适配器
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //创建一个dataset实例，存放数据
                DataSet ds = new DataSet();
                //填充数据集
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="cmdtype">命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递参数</param>
        /// <returns></returns>

        public static int ExecuteNonQuery(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            //初始化连接对象
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.CommandType = cmdtype;
                //添加数据
                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }
                int count = cmd.ExecuteNonQuery();

                return count;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        /// <summary>
        /// DataTable查询
        /// </summary>
        /// <param name="cmdtype">命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递参数</param>
        /// <returns></returns>

        public static DataTable ExecuteDataTable(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            DataSet ds = ExecuteDataSet(cmdtype, sql, parm);
            return ds.Tables[0];
        }




        /// <summary>
        /// 查询首行首列的值
        /// </summary>
        /// <param name="cmdtype">命令对象</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parm">传递参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(CommandType cmdtype, string sql, params SqlParameter[] parm)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                object var = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return var;
            }

        }

        /// <summary>
        /// 创建一个关联connection可以执行Command的方法
        /// </summary>
        /// <param name="cmdtype"></param>
        /// <param name="sql"></param>
        /// <param name="parm"></param>
        public static void PrepareCommand(SqlConnection con, SqlCommand cmd, CommandType comType, string sql, params SqlParameter[] parm)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = comType;
            cmd.CommandText = sql;
            if (parm == null)
            {
                return;
            }
            foreach (SqlParameter p in parm)
            {
                cmd.Parameters.Add(parm);
            }
        }
    }
}
