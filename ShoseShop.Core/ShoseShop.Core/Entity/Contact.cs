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
    [Table("Contact")]
    public class Contact : BaseEntity
    {
        public int ContactID { get; set; }

        public string CustomerName { get; set; }

        public string Content { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateContact { get; set; }
    }
}
