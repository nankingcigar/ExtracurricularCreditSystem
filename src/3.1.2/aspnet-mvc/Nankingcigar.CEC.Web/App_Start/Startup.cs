using Abp.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Nankingcigar.CEC.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Nankingcigar.CEC.Web
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.UseAbp();
      app.UseCookieAuthentication(new CookieAuthenticationOptions
      {
        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
      });
      app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
      app.MapSignalR();
    }
  }
}