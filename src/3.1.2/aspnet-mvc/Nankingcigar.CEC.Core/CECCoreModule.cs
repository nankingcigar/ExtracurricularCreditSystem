using Abp.Authorization;
using Abp.Dependency;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using Nankingcigar.CEC.Core.DataService;
using Nankingcigar.CEC.Core.Domain;
using Nankingcigar.CEC.Core.Domain.Authorization;
using Nankingcigar.CEC.Core.Extension;
using System.Reflection;

namespace Nankingcigar.CEC
{
  public class CECCoreModule : AbpModule
  {
    public override void PreInitialize()
    {
      base.PreInitialize();
      IocManager.Register<IAuthorizationHelper, AuthorizationHelper>(DependencyLifeStyle.Transient);

      IocManager.IocContainer.Register(Component
          .For(typeof(ICECSession))
          .ImplementedBy(typeof(CECSession))
          .LifestylePerWebRequest());
      IocManager.IocContainer.Register(Component
          .For(typeof(IUserStoreExtension))
          .ImplementedBy(typeof(UserStore))
          .LifestyleTransient());
    }

    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
    }
  }
}