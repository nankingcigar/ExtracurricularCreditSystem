using Nankingcigar.CEC.Core.Entity.POCO;
using System.Data.Entity.ModelConfiguration;

namespace Nankingcigar.CEC.EntityFramework.Mapper
{
  internal sealed class UserMapper : EntityTypeConfiguration<User>
  {
    public UserMapper()
    {
      HasMany(entity => entity.Roles)
        .WithRequired(entity => entity.User)
        .HasForeignKey(entity => entity.UserId);
    }
  }
}