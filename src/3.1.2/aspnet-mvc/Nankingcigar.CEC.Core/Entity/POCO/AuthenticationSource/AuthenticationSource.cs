using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class AuthenticationSource : Entity<int>
  {
    private const int NAME_LENGTH = 64;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AuthenticationSource()
    {
      Users = new HashSet<User>();
    }

    [Required, StringLength(NAME_LENGTH)]
    public string Name { get; set; }

    [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public ICollection<User> Users { get; set; }
  }
}