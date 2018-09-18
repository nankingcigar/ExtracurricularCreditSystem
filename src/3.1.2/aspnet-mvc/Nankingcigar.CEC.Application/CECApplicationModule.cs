using Abp.Modules;
using System.Reflection;

namespace Nankingcigar.CEC
{
  [DependsOn(typeof(CECCoreModule))]
  public class CECApplicationModule : AbpModule
  {
    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
    }
  }
}