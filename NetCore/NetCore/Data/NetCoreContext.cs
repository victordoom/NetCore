using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Models
{
    public class NetCoreContext : DbContext
    {
        public NetCoreContext (DbContextOptions<NetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<NetCore.Models.Categoria> Categoria { get; set; }
    }
}
