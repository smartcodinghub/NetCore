using System;
using System.Collections.Generic;

namespace NetCore.Domain
{
    public class User : Entity<User>
    {
        public string Name { get; set; }

        public long RolId { get; set; }
        public Rol Rol { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
