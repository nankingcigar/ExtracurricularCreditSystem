using Nankingcigar.CEC.Core.Entity.POCO;
using Nankingcigar.CEC.Core.Extension;
using System.Linq;
using System.Threading.Tasks;

namespace Nankingcigar.CEC.Core.DataService
{
  internal class UserStore :
    IUserStoreExtension
  {
    public IDapperRepositoryExtension<User, long> UserDapperRepository { get; set; }

    public IQueryable<User> Users => UserDapperRepository.GetAll().AsQueryable();

    public async Task CreateAsync(User user)
    {
      await UserDapperRepository.InsertAsync(user);
    }

    public async Task UpdateAsync(User user)
    {
      await UserDapperRepository.UpdateAsync(user);
    }

    public async Task DeleteAsync(User user)
    {
      await UserDapperRepository.DeleteAsync(user);
    }

    public async Task<User> FindByIdAsync(long userId)
    {
      return await UserDapperRepository.FirstOrDefaultAsync(userId);
    }

    public async Task<User> FindByNameAsync(string userName)
    {
      return await UserDapperRepository.FirstOrDefaultAsync(user => user.UserName == userName);
    }

    public Task SetPasswordHashAsync(User user, string passwordHash)
    {
      user.Password = passwordHash;
      return Task.FromResult(0);
    }

    public Task<string> GetPasswordHashAsync(User user)
    {
      return Task.FromResult(user.Password);
    }

    public Task<bool> HasPasswordAsync(User user)
    {
      return Task.FromResult(!string.IsNullOrEmpty(user.Password));
    }

    public Task SetEmailAsync(User user, string email)
    {
      user.Email = email;
      return Task.FromResult(0);
    }

    public Task<string> GetEmailAsync(User user)
    {
      return Task.FromResult(user.Email);
    }

    public Task<bool> GetEmailConfirmedAsync(User user)
    {
      return Task.FromResult(false);
    }

    public Task SetEmailConfirmedAsync(User user, bool confirmed)
    {
      return Task.FromResult(0);
    }

    public async Task<User> FindByEmailAsync(string email)
    {
      return await UserDapperRepository.FirstOrDefaultAsync(
          user => user.Email == email
      );
    }

    public void Dispose()
    {
    }

    public async Task<User> FindByNameOrEmailOrNoAsync(string userNameOrEmailAddressOrNo)
    {
      return await UserDapperRepository.FirstOrDefaultAsync(
          user => user.UserName == userNameOrEmailAddressOrNo || user.Email == userNameOrEmailAddressOrNo || user.No == userNameOrEmailAddressOrNo
      );
    }
  }
}