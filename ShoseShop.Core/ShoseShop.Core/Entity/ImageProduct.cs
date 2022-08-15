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
    [Table("ImageProduct")]
    public class ImageProduct : BaseEntity
    {
        public int ImageID { get; set; }

        public string Images { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
