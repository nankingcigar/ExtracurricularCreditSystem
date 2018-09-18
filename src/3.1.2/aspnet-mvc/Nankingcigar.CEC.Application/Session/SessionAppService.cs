using Abp.Authorization;
using Nankingcigar.CEC.Application.Session.DTO;
using Nankingcigar.CEC.Core.Domain;
using Nankingcigar.CEC.Core.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Application.Session
{
  internal class SessionAppService : CECAppServiceBase, ISessionAppService
  {
    private const int CODE_ERROR_CREATE = 1;

    private ILoginManager _loginManager;

    public SessionAppService(
      ILoginManager loginManager
      )
    {
      _loginManager = loginManager;
    }

    [AbpAllowAnonymous]
    public async Task<ClaimsIdentity> Create(Login login)
    {
      if (login.AuthenicationSourceId.HasValue)
      {
        // TODO: validate user by Authenication Source
        return null;
      }
      else
      {
        var identity = await _loginManager.LoginAsync(login.Name, login.Password);
        if (identity == null) throw new ApiException(CODE_ERROR_CREATE);
        return identity;
      }
    }
  }
}