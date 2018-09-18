using Abp.Dapper.Repositories;
using Abp.Data;
using Abp.Domain.Entities;
using Nankingcigar.CEC.Core.Extension;
using System.Data;

namespace Nannkingcigar.CEC.Dapper.Repository
{
  public class CECDapperRepositoryBase<TDbContext, TEntity, TPrimaryKey> : DapperEfRepositoryBase<TDbContext, TEntity, TPrimaryKey>, IDapperRepositoryExtension<TEntity, TPrimaryKey>
      where TEntity : class, IEntity<TPrimaryKey>
  {
    private IRepositoryExtension<TEntity, TPrimaryKey> _repository;

    public CECDapperRepositoryBase(
      IActiveTransactionProvider activeTransactionProvider,
      IRepositoryExtension<TEntity, TPrimaryKey> repository
      ) : base(activeTransactionProvider)
    {
      _repository = repository;
    }

    public IDbConnection GetConnection()
    {
      return Connection;
    }

    public IDbTransaction GetTransaction()
    {
      return ActiveTransaction;
    }
  }

  public class CECDapperRepositoryBase<TDbContext, TEntity> : CECDapperRepositoryBase<TDbContext, TEntity, int>, IDapperRepositoryExtension<TEntity>
      where TEntity : class, IEntity<int>
      where TDbContext : class
  {
    public CECDapperRepositoryBase(
      IActiveTransactionProvider activeTransactionProvider,
      IRepositoryExtension<TEntity> repository
      ) : base(activeTransactionProvider, repository)
    {
    }
  }
}