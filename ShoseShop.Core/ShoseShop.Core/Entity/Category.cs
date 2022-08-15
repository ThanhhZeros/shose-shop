using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
