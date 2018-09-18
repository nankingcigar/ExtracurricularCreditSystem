using Abp.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Nankingcigar.CEC.Application;
using Nankingcigar.CEC.Application.Session.DTO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Nankingcigar.CEC.Controllers
{
  [RoutePrefix(SESSION_PREFIX)]
  public class SessionController : BaseApiController
  {
    private const string SESSION_PREFIX = "api/session";

    private IAuthenticationManager _authenticationManager;

    private ISessionAppService _sessionService;

    public SessionController(
      ISessionAppService sessionService
      )
    {
      _authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
      _sessionService = sessionService;
    }

    [AllowAnonymous, AbpAllowAnonymous, HttpPost, Route]
    public async Task Create(Login input)
    {
      var identity = await _sessionService.Create(input);
      Delete();
      _authenticationManager.SignIn(identity);
    }

    [AllowAnonymous, AbpAllowAnonymous, HttpDelete, Route]
    public void Delete()
    {
      _authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
    }
  }
}