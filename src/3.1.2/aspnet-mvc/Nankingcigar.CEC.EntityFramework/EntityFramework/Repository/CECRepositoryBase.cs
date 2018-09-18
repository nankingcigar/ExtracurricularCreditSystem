using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using Nankingcigar.CEC.Core.Extension;

namespace Nankingcigar.CEC.EntityFramework.Repository
{
  internal class CECRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CECDbContext, TEntity, TPrimaryKey>, IRepositoryExtension<TEntity, TPrimaryKey>
      where TEntity : class, IEntity<TPrimaryKey>
  {
    public CECRepositoryBase(IDbContextProvider<CECDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    //add common methods for all repositories
  }

  internal class CECRepositoryBase<TEntity> : CECRepositoryBase<TEntity, int>, IRepositoryExtension<TEntity>
      where TEntity : class, IEntity<int>
  {
    public CECRepositoryBase(IDbContextProvider<CECDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    //do not add any method here, add to the class above (since this inherits it)
  }
}