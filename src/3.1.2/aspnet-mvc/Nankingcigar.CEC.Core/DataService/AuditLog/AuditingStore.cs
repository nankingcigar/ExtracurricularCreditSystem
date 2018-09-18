using Abp.Auditing;
using Abp.Dependency;
using Nankingcigar.CEC.Core.Entity.POCO;
using Nankingcigar.CEC.Core.Extension;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.DataService
{
  internal class AuditingStore : IAuditingStore, ITransientDependency
  {
    public IDapperRepositoryExtension<AuditLog, long> AuditLogDapperRepository { get; set; }

    public async Task SaveAsync(AuditInfo auditInfo)
    {
      await AuditLogDapperRepository.InsertAsync(AuditLog.CreateFromAuditInfo(auditInfo));
    }
  }
}