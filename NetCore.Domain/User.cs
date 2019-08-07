using System;

namespace NetCore.Domain
{
    public class User : Entity<User>
    {
        public string Name { get; set; }
    }
}
