using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Domain
{
    public class Entity<T> where T : Entity<T>
    {
        public long Id { get; set; }
    }
}
