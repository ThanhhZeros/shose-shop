using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    public class Orders: BaseEntity
    {
        public int OrderID { get; set; }

        public int? UserID { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public DateTime DateCreate { get; set; }

        public string Status { get; set; }

        public string Note { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; }
    }
}
