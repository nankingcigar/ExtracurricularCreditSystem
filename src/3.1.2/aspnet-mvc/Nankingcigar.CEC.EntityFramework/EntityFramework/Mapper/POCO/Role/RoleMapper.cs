using Nankingcigar.CEC.Core.Entity.POCO;
using System.Data.Entity.ModelConfiguration;

namespace Nankingcigar.CEC.EntityFramework.Mapper
{
  internal sealed class RoleMapper : EntityTypeConfiguration<Role>
  {
    public RoleMapper()
    {
      HasMany(entity => entity.Users)
        .WithRequired(entity => entity.Role)
        .HasForeignKey(entity => entity.RoleId);
    }
  }
}