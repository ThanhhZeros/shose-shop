using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoseShop.Core.Entity
{
    [Table("BlogCategory")]
    public class BlogCategory : BaseEntity
    {
        public int BlogCategoryID { get; set; }

        public string BlogCategoryName { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}
