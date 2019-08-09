using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Domain
{
    public class Rol : Entity<Rol>
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
