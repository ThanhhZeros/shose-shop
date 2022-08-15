using ShoseShop.Core.BaseEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoseShop.Core.Entity
{
    [Table("Blog")]
    public class Blog : BaseEntity
    {
        public int BlogID { get; set; }

        public string BlogName { get; set; }

        public string Content { get; set; }

        public string Images { get; set; }
        public int? BlogCategoryID { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }
}
