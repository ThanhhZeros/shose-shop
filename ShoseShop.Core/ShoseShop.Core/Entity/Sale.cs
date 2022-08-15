using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    [Table("Sale")]
    class Sale
    {
        public int SaleID { get; set; }

        public string SaleName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
