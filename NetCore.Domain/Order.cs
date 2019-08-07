using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Domain
{
    public class Order : Entity<Order>
    {
        public DateTime Date { get; set; }
    }
}
