using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDemo.Framework.Mapping
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumAttribute : BaseMappingAttribute
    {
        public ColumAttribute(string columname):base(columname)
        { }       
         
    }
}
