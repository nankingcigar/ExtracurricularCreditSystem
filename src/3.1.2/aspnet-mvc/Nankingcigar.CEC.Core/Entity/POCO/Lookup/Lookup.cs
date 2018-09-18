using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class Lookup : Entity<int>
  {
    private const int NAME_LENGTH = 64;
    private const int DISPLAYNAME_LENGTH = 16;
    private const int DESCRIPTION_LENGTH = 256;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Lookup()
    {
    }

    public int LookupCategoryId { get; set; }

    [Required, StringLength(NAME_LENGTH)]
    public string Name { get; set; }

    [StringLength(DISPLAYNAME_LENGTH)]
    public string DisplayName { get; set; }

    [StringLength(DESCRIPTION_LENGTH)]
    public string Description { get; set; }

    public LookupCategory LookupCategory { get; set; }
  }
}