using ORMDemo.Framework.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDemo.Model
{
    public class UserModel
    {
        public string Name { get; set; }
        [ColumAttribute("statu")]
        public  bool status { get; set; }
    }
}
