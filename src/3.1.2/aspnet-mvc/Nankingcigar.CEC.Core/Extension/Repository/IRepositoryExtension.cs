using Abp.Domain.Entities;
using Abp.Domain.Repositories;

namespace Nankingcigar.CEC.Core.Extension
{
  public interface IRepositoryExtension<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
  {
  }

  public interface IRepositoryExtension<TEntity> : IRepositoryExtension<TEntity, int>, IRepository<TEntity>
      where TEntity : class, IEntity<int>
  {
  }
}