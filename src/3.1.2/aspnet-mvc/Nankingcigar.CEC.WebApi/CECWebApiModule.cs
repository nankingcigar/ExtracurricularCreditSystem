using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using System.Reflection;

namespace Nankingcigar.CEC
{
  [DependsOn(typeof(AbpWebApiModule), typeof(CECApplicationModule))]
  public class CECWebApiModule : AbpModule
  {
    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

      Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
          .ForAll<IApplicationService>(typeof(CECApplicationModule).Assembly, "app")
          .Build();
    }
  }
}