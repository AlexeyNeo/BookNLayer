using System.Collections.Generic;
//using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using NLayerApp.DAL.Entities;

namespace NLayerApp.DAL.EF
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(): base("DefaultConnection")
        {
            Database.SetInitializer<MobileContext>(new DbInitializer());
        }
        public MobileContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer<MobileContext>(new DbInitializer());
        }

    }
}
