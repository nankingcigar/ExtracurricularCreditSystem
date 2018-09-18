using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class Role : Entity<int>
  {
    private const int NAME_LENGTH = 64;
    private const int DISPLAYNAME_LENGTH = 16;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Role()
    {
      Users = new HashSet<RoleUser>();
    }

    [Required, StringLength(NAME_LENGTH)]
    public string Name { get; set; }

    [StringLength(DISPLAYNAME_LENGTH)]
    public string DisplayName { get; set; }

    public bool IsStatic { get; set; }
    public bool IsDefault { get; set; }
    public bool IsMutex { get; set; }

    [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public ICollection<RoleUser> Users { get; set; }
  }
}