using Abp.Domain.Uow;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.Domain
{
  internal class LoginManager : BaseDomainService, ILoginManager
  {
    public UserManager UserManager { get; set; }

    [UnitOfWork]
    public async Task<ClaimsIdentity> LoginAsync(string userNameOrEmailAddressOrNo, string plainPassword)
    {
      var user = await UserManager.FindByNameOrEmailOrNoAsync(userNameOrEmailAddressOrNo);
      if (user == null) return null;
      if (user.AuthenticationSourceId.HasValue)
      {
        // TODO: validate user by Authenication Source
      }
      else
      {
        var verificationResult = UserManager.PasswordHasher.VerifyHashedPassword(user.Password, plainPassword);
        if (verificationResult == PasswordVerificationResult.Failed) return null;
        if (verificationResult == PasswordVerificationResult.SuccessRehashNeeded) return null;
      }
      if (!user.IsActive) return null;
      return await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
    }
  }
}