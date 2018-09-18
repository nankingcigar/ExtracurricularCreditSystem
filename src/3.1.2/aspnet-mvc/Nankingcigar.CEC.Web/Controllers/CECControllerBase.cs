using Abp.Web.Mvc.Controllers;

namespace Nankingcigar.CEC.Web.Controllers
{
  /// <summary>
  /// Derive all Controllers from this class.
  /// </summary>
  public abstract class CECControllerBase : AbpController
  {
    protected CECControllerBase()
    {
      LocalizationSourceName = CECConsts.LocalizationSourceName;
    }
  }
}