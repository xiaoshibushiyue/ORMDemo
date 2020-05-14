using ORMDemo.Framework.DBFilter;
using ORMDemo.Framework.Mapping;
using ORMDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMDemo.DAL
{
   public class SqlCacheBuilder<T> where T: BaseModel
    {
        private static string _InsertSql = null;
        static SqlCacheBuilder()
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]"));
            string valueString = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"@[{p.GetMappingName()}]"));
            _InsertSql = $"insert into [{type.GetMappingName()}]({columnString}) values ({valueString})";
        }
        public static string GetSql()
        {
            return _InsertSql;
        }
    }
}
