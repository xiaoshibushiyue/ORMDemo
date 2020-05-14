using ORMDemo.Framework;
using ORMDemo.Framework.DBFilter;
using ORMDemo.Framework.Mapping;
using ORMDemo.Model;
using System;

using System.Data.SqlClient;
using System.Linq;

namespace ORMDemo.DAL
{
    public class SqlHelper
    {
        private static string ConnectStringCustomers = ConfigurationManager.SqlConnectionSreingCustom;


        public T Find<T>(int id) where T : BaseModel
        {
            Type type = typeof(T);
            string columstring = string.Join(",", type.GetProperties().Select(p => $"[{p.GetMappingName()}]"));
            string sql = $@"select {columstring} from [{type.GetMappingName()}] where ID={id}";
            using (SqlConnection conn = new SqlConnection(ConnectStringCustomers))
            {
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                conn.Open();
                var reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    T t = Activator.CreateInstance<T>();
                    foreach (var prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.GetMappingName()] is DBNull ? null : reader[prop.GetMappingName()]);
                    }
                    return t;
                }
                else
                {
                    return null;
                }


            }
        }
        public bool Insert<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);
            string sql=SqlCacheBuilder<T>.GetSql();
            //参数化，防注入
            var parameters = type.GetProperties().Select(p=>new SqlParameter($"@{p.GetMappingName()}",p.GetValue(t)??DBNull.Value));
         
           
            using (SqlConnection connection=new SqlConnection(ConnectStringCustomers))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql,connection);
                sqlCommand.Parameters.AddRange(parameters.ToArray());
                int iresult= sqlCommand.ExecuteNonQuery();
                return iresult==1;
            }
        }
    }
}

