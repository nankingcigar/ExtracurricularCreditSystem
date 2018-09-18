using Abp.Domain.Services;
using Abp.Events.Bus;
using Nankingcigar.CEC.Core.Extension;

namespace Nankingcigar.CEC.Core.Domain
{
  internal abstract class BaseDomainService : DomainService
  {
    public IEventBus EventBus { get; set; }
    public ICECSession Session { get; set; }
  }
}