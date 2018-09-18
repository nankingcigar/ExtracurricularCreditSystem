using Abp.Domain.Entities;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class User : Entity<long>, IPassivable, IUser<long>
  {
    private const int USERNAME_LENGTH = 64;
    private const int DISPLAYNAME_LENGTH = 16;
    private const int NO_LENGTH = 64;
    private const int PASSWORD_LENGTH = 256;
    private const int PHONE_LENGTH = 16;
    private const int EMAIL_LENGTH = 128;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {
      Roles = new HashSet<RoleUser>();
    }

    public int? AuthenticationSourceId { get; set; }

    [Column("Name"), Required, StringLength(USERNAME_LENGTH)]
    public string UserName { get; set; }

    [StringLength(DISPLAYNAME_LENGTH)]
    public string DisplayName { get; set; }

    [StringLength(NO_LENGTH)]
    public string No { get; set; }

    [StringLength(PASSWORD_LENGTH)]
    public string Password { get; set; }

    [StringLength(PHONE_LENGTH)]
    public string Phone { get; set; }

    [StringLength(EMAIL_LENGTH)]
    public string Email { get; set; }

    public bool IsActive { get; set; }

    public AuthenticationSource AuthenticationSource { get; set; }

    [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public ICollection<RoleUser> Roles { get; set; }
  }
}