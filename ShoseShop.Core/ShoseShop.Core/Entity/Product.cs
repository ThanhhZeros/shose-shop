using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int CategoryID { get; set; }
        //public int? SaleID { get; set; }

        public string Descriptions { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateUpdate { get; set; }
        public Category Category { get; set; }
        public ICollection<ImageProduct> ImageProducts { get; set; }
    }
}
