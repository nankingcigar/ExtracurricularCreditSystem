using Abp.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class RoleUser : Entity<long>
  {
    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public RoleUser()
    {
    }

    public int RoleId { get; set; }
    public long UserId { get; set; }

    public Role Role { get; set; }
    public User User { get; set; }
  }
}