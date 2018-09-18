using Abp.EntityFramework;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using Nankingcigar.CEC.Core.Extension;
using Nankingcigar.CEC.EntityFramework;
using Nankingcigar.CEC.EntityFramework.Repository;
using System.Data.Entity;
using System.Reflection;

namespace Nankingcigar.CEC
{
  [DependsOn(typeof(AbpEntityFrameworkModule), typeof(CECCoreModule))]
  public class CECDataModule : AbpModule
  {
    public override void PreInitialize()
    {
      Configuration.DefaultNameOrConnectionString = "Default";
    }

    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
      Database.SetInitializer<CECDbContext>(null);

      IocManager.IocContainer.Register(Component
          .For(typeof(IRepositoryExtension<,>))
          .ImplementedBy(typeof(CECRepositoryBase<,>))
          .LifestyleTransient());
      IocManager.IocContainer.Register(Component
          .For(typeof(IRepositoryExtension<>))
          .ImplementedBy(typeof(CECRepositoryBase<>))
          .LifestyleTransient());
    }
  }
}