using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Domain
{
    public class Order : Entity<Order>
    {
        public DateTime Date { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
