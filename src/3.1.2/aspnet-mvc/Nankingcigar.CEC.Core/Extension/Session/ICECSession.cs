using Abp.Runtime.Session;
using Nankingcigar.CEC.Core.Entity.POCO;
using System.Collections.Generic;

namespace Nankingcigar.CEC.Core.Extension
{
  public interface ICECSession : IAbpSession
  {
    IEnumerable<Role> Roles { get; }
  }
}