using Nankingcigar.CEC.Core.Entity.POCO;
using System.Data.Entity.ModelConfiguration;

namespace Nankingcigar.CEC.EntityFramework.Mapper
{
  internal sealed class AuditLogMapper : EntityTypeConfiguration<AuditLog>
  {
    public AuditLogMapper()
    {
    }
  }
}