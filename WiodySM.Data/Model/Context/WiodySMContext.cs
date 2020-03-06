using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WiodySM.Data.Configuration;
using WiodySM.Data.Model.Entity;
using WiodySM.Data.Model.Entity.Base;
using WiodySM.Data.Utilities;

namespace WiodySM.Data.Model.Context
{
    public class WiodySMContext : DbContext
    {
        public WiodySMContext()
           : base("WiodySMContext")
        {

        }
        public DbSet<User> User { get; set; }

        public DbSet<ParameterMaster> ParameterMaster { get; set; }

        public DbSet<ParameterDetail> ParameterDetail { get; set; }

        public DbSet<StockDetail> StockDetail { get; set; }

        public DbSet<StockMaster> StockMaster { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<Contract> Contract { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<ProjectExplore> ProjectExplore { get; set; }

        public DbSet<ProjectManager> ProjectManager { get; set; }

        public DbSet<ItemDemandMaster> ItemDemandMaster { get; set; }

        public DbSet<ItemDemandDetail> ItemDemandDetail { get; set; }

        public DbSet<MenuRole> MenuRole { get; set; }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<PayoffMaster> PayoffMaster { get; set; }
        public DbSet<PayoffDetail> PayoffDetail { get; set; }
        public DbSet<PayoffDefault> PayoffDefault { get; set; }
        public DbSet<PayoffControl> PayoffControl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WiodySMContext>(new MigrateDatabaseToLatestVersion<WiodySMContext, EFConfiguration>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public override int SaveChanges()
        {
            var Entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            string identity = WindowsIdentity.GetCurrent().Name;
            DateTime date = DateTime.Now;
            string ip = IPRemote.IpAddress;

            foreach (var item in Entries)
            {
                EntityBase entity = item.Entity as EntityBase;
                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CREATED_USER_IP = ip;
                        entity.ISACTIVE = true;
                        entity.MACHINENAME_MACHINEIDENTITY = identity;
                        entity.CREATED_USER_ID = SystemActive.UserId;
                        entity.CREATED_DATE = date;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
