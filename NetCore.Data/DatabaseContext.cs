using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Data
{
    public class DatabaseContext : GenericDbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
