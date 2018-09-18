using Abp.Dapper;
using Abp.Modules;
using Abp.Orm;
using Abp.Reflection.Extensions;
using Nankingcigar.CEC.Core.Extension;
using Nannkingcigar.CEC.Dapper.Repository;
using System.Collections.Generic;
using System.Reflection;

namespace Nannkingcigar.CEC.Dapper
{
  [DependsOn(typeof(AbpDapperModule))]
  public class CECDapperModule : AbpDapperModule
  {
    public override void Initialize()
    {
      IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
      DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(CECDapperModule).GetAssembly() });

      ISecondaryOrmRegistrar additionalOrmRegistrar = IocManager.Resolve<ISecondaryOrmRegistrar>();
      additionalOrmRegistrar.RegisterRepositories(IocManager, new DapperAutoRepositoryTypeAttribute(
          typeof(IDapperRepositoryExtension<>),
          typeof(IDapperRepositoryExtension<,>),
          typeof(CECDapperRepositoryBase<,>),
          typeof(CECDapperRepositoryBase<,,>)
          ));
    }
  }
}