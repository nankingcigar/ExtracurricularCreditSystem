using System.Data.Entity.Migrations;

namespace Nankingcigar.CEC.Migrations
{
  internal sealed class Configuration : DbMigrationsConfiguration<CEC.EntityFramework.CECDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
      ContextKey = "CEC";
    }

    protected override void Seed(CEC.EntityFramework.CECDbContext context)
    {
      // This method will be called every time after migrating to the latest version.
      // You can add any seed data here...
    }
  }
}