using Abp.Application.Services;
using Abp.Authorization;
using Nankingcigar.CEC.Core.Extension;

namespace Nankingcigar.CEC
{
  /// <summary>
  /// Derive your application services from this class.
  /// </summary>
  [AbpAuthorize]
  internal abstract class CECAppServiceBase : ApplicationService
  {
    protected CECAppServiceBase()
    {
      LocalizationSourceName = CECConsts.LocalizationSourceName;
    }

    public ICECSession Session { get; set; }
  }
}