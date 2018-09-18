using Abp.Domain.Services;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.Domain
{
  public interface ILoginManager : IDomainService
  {
    Task<ClaimsIdentity> LoginAsync(string userNameOrEmailAddressOrNo, string plainPassword);
  }
}