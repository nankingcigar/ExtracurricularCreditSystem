using Abp.Application.Services;
using Abp.Authorization;
using Nankingcigar.CEC.Application.Session.DTO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Application
{
  public interface ISessionAppService : IApplicationService, ISessionService
  {
    Task<ClaimsIdentity> Create(Login login);
  }

  public interface ISessionService
  {
  }
}