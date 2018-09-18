using DapperExtensions.Mapper;
using Nankingcigar.CEC.Core.Entity.POCO;
using System.Linq;

namespace Nankingcigar.CEC.Dapper.Mapper
{
  public sealed class UserMapper : BaseMapper<User>
  {
    public UserMapper()
      : base()
    {
      (Properties.First(entity => entity.Name == "UserName") as PropertyMap).Column("Name");
    }
  }
}