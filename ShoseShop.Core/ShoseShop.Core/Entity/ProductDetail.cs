using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    [Table("ProductDetail")]
    public class ProductDetail : BaseEntity
    {
        public int SizeID { get; set; }
        public int ImageID { get; set; }

        public int Size { get; set; }
        public int AmountInput { get; set; }
        public ImageProduct ImageProduct { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
