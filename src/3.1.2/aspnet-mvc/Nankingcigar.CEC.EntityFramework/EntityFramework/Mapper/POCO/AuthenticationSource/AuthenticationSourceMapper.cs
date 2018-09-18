using Nankingcigar.CEC.Core.Entity.POCO;
using System.Data.Entity.ModelConfiguration;

namespace Nankingcigar.CEC.EntityFramework.Mapper
{
  internal sealed class AuthenticationSourceMapper : EntityTypeConfiguration<AuthenticationSource>
  {
    public AuthenticationSourceMapper()
    {
      HasMany(entity => entity.Users)
        .WithOptional(entity => entity.AuthenticationSource)
        .HasForeignKey(entity => entity.AuthenticationSourceId);
    }
  }
}