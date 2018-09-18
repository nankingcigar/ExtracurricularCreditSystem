using Abp.Dependency;
using Abp.Domain.Services;
using Microsoft.AspNet.Identity;
using Nankingcigar.CEC.Core.DataService;
using Nankingcigar.CEC.Core.Entity.POCO;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.Domain
{
  internal class UserManager : UserManager<User, long>, IUserManager, IDomainService
  {
    private IUserStoreExtension _userStore;

    public UserManager(
      IUserStoreExtension userStore
      ) : base(userStore)
    {
      _userStore = userStore;
    }

    public async Task<User> FindByNameOrEmailOrNoAsync(string userNameOrEmailAddressOrNo)
    {
      return await _userStore.FindByNameOrEmailOrNoAsync(userNameOrEmailAddressOrNo);
    }
  }
}