﻿using ShoseShop.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core.Entity
{
    public class Role : BaseEntity
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
