using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDemo.Framework.Mapping
{
    public class BaseMappingAttribute:Attribute
    {
        private string Mappingname = null;
        public BaseMappingAttribute(string Mappingname)
        {
            this.Mappingname = Mappingname;
        }
        public string GetMappingname()
        {
            return this.Mappingname;
        }
    }
}
