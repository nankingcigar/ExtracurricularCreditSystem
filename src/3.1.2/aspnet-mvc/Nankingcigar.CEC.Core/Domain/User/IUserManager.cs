using Abp.Domain.Services;
using Nankingcigar.CEC.Core.Entity.POCO;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.Domain
{
  public interface IUserManager : IDomainService
  {
    Task<User> FindByNameOrEmailOrNoAsync(string userNameOrEmailAddressOrNo);
  }
}