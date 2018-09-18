using Nankingcigar.CEC.Core.Entity.POCO;
using System.Data.Entity.ModelConfiguration;

namespace Nankingcigar.CEC.EntityFramework.Mapper
{
  internal sealed class LookupCategoryMapper : EntityTypeConfiguration<LookupCategory>
  {
    public LookupCategoryMapper()
    {
      HasMany(entity => entity.Lookups)
        .WithRequired(entity => entity.LookupCategory)
        .HasForeignKey(entity => entity.LookupCategoryId);
    }
  }
}