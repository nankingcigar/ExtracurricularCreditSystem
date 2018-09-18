using Abp.Domain.Entities;
using Abp.EntityFramework;
using EntityFramework.DynamicFilters;
using Nankingcigar.CEC.Core.Entity.POCO;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Nankingcigar.CEC.EntityFramework
{
  public sealed class CECDbContext : AbpDbContext
  {
    //TODO: Define an IDbSet for each Entity...

    //Example:
    //public virtual IDbSet<User> Users { get; set; }
    public IDbSet<AuthenticationSource> AuthenticationSource { get; set; }

    public IDbSet<User> User { get; set; }
    public IDbSet<Role> Role { get; set; }
    public IDbSet<RoleUser> RoleUser { get; set; }
    public IDbSet<AuditLog> AuditLog { get; set; }
    public IDbSet<LookupCategory> LookupCategory { get; set; }
    public IDbSet<Lookup> Lookup { get; set; }
    public IDbSet<College> College { get; set; }

    /* NOTE:
     *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
     *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
     *   pass connection string name to base classes. ABP works either way.
     */

    public CECDbContext()
        : base("Default")
    {
      Configuration.ProxyCreationEnabled = false;
      Configuration.ValidateOnSaveEnabled = false;
      Configuration.AutoDetectChangesEnabled = false;
    }

    /* NOTE:
     *   This constructor is used by ABP to pass connection string defined in CECDataModule.PreInitialize.
     *   Notice that, actually you will not directly create an instance of CECDbContext since ABP automatically handles it.
     */

    public CECDbContext(string nameOrConnectionString)
        : base(nameOrConnectionString)
    {
    }

    //This constructor is used in tests
    public CECDbContext(DbConnection existingConnection)
     : base(existingConnection, false)
    {
    }

    public CECDbContext(DbConnection existingConnection, bool contextOwnsConnection)
     : base(existingConnection, contextOwnsConnection)
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      Assembly.GetExecutingAssembly().GetTypes().Where(
          entity => entity.BaseType != null &&
              entity.BaseType.IsGenericType &&
              entity.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
              .ToList().ForEach(type =>
              {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
              });

      modelBuilder.Filter("IPassivable", (IPassivable passivable) => passivable.IsActive, true);
    }
  }
}