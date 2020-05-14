using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDemo.Framework.Mapping
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute:BaseMappingAttribute
    {
       
        public TableAttribute(string tablename):base (tablename)
        { }
      
    }
}
