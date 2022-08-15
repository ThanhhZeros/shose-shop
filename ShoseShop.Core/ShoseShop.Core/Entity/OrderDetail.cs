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
    [Table("OrderDetail")]
    public class OrderDetail : BaseEntity
    {
        public int OrderID { get; set; }

        public int ImageID { get; set; }

        public int SizeID { get; set; }

        public int Amount { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Orders Orders { get; set; }
    }
}
