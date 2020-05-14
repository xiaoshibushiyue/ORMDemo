using ORMDemo.Framework.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDemo.Model
{
    /// <summary>
    /// 数据库表字段和类的字段不是完全一样
    /// </summary>
    [TableAttribute("Company")]
    public class CompanyModel : BaseModel
    {
        public string name { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }
        public Nullable<int> GetV { get; set; }
        public DateTime? b { get; set; }
    }
}
