using Microsoft.AspNet.Identity.EntityFramework;
using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public int? RoleID { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public Role Role { get; set; }
    }
}
