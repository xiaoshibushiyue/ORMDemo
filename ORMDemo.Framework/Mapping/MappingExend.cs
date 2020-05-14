using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace ORMDemo.Framework.Mapping
{
   public static class MappingExend
    {

        public static string GetMappingName<T>(this T t) where T:MemberInfo
        {
            if (t.IsDefined(typeof(BaseMappingAttribute), true))
            {
                return t.GetCustomAttribute<BaseMappingAttribute>().GetMappingname();
            }
            else
            {
                return t.Name;
            }
        }
      
    }
}
