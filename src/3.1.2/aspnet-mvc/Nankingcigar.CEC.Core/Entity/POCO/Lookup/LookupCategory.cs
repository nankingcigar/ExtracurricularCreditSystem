using Abp.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public class LookupCategory : Entity<int>
  {
    private const int NAME_LENGTH = 64;
    private const int DISPLAYNAME_LENGTH = 16;
    private const int DESCRIPTION_LENGTH = 256;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LookupCategory()
    {
      Lookups = new HashSet<Lookup>();
    }

    [Required, StringLength(NAME_LENGTH)]
    public string Name { get; set; }

    [StringLength(DISPLAYNAME_LENGTH)]
    public string DisplayName { get; set; }

    [StringLength(DESCRIPTION_LENGTH)]
    public string Description { get; set; }

    public ICollection<Lookup> Lookups { get; set; }
  }
}