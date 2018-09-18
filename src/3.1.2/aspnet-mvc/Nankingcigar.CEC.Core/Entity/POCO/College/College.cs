using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class College : Entity<int>
  {
    private const int NAME_LENGTH = 64;
    private const int DISPLAYNAME_LENGTH = 16;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public College()
    {
    }

    [Required, StringLength(NAME_LENGTH)]
    public string Name { get; set; }

    [StringLength(DISPLAYNAME_LENGTH)]
    public string DisplayName { get; set; }
  }
}