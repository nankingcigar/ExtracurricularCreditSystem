using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using Nankingcigar.CEC.Core.Extension;
using System;
using System.Web.Http;

namespace Nankingcigar.CEC.Web
{
  public class MvcApplication : AbpWebApplication<CECWebModule>
  {
    protected override void Application_Start(object sender, EventArgs e)
    {
      AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                      f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
                  );
      GlobalConfiguration.Configure((config) =>
      {
        config.MapHttpAttributeRoutes();
      });
      base.Application_Start(sender, e);
      GlobalConfiguration.Configure((config) =>
      {
        config.Formatters.JsonFormatter.SerializerSettings.Converters[0] = new CECDateTimeConverter();
      });
    }
  }
}