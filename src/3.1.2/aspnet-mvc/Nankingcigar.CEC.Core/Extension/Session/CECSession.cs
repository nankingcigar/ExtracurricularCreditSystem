using Abp.Configuration.Startup;
using Abp.MultiTenancy;
using Abp.Runtime;
using Abp.Runtime.Session;
using Nankingcigar.CEC.Core.Entity.POCO;
using System;
using System.Collections.Generic;

namespace Nankingcigar.CEC.Core.Extension
{
  internal sealed class CECSession : ClaimsAbpSession, ICECSession
  {
    public CECSession(
        IPrincipalAccessor principalAccessor,
        IMultiTenancyConfig multiTenancy,
        ITenantResolver tenantResolver,
        IAmbientScopeProvider<SessionOverride> sessionOverrideScopeProvider)
        : base(
              principalAccessor,
              multiTenancy,
              tenantResolver,
              sessionOverrideScopeProvider)
    {
    }

    public IEnumerable<Role> Roles => throw new NotImplementedException();
  }
}