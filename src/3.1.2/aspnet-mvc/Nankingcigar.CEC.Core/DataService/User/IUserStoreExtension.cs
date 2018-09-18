using Abp.Dependency;
using Microsoft.AspNet.Identity;
using Nankingcigar.CEC.Core.Entity.POCO;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.DataService
{
  public interface IUserStoreExtension :
    IUserStore<User, long>,
    IUserPasswordStore<User, long>,
    IUserEmailStore<User, long>,
    IQueryableUserStore<User, long>,
    ITransientDependency
  {
    Task<User> FindByNameOrEmailOrNoAsync(string userNameOrEmailAddressOrNo);
  }
}