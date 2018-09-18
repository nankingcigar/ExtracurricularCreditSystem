using Abp.Web.Mvc.Views;

namespace Nankingcigar.CEC.Web.Views
{
  public abstract class CECWebViewPageBase : CECWebViewPageBase<dynamic>
  {
  }

  public abstract class CECWebViewPageBase<TModel> : AbpWebViewPage<TModel>
  {
    protected CECWebViewPageBase()
    {
      LocalizationSourceName = CECConsts.LocalizationSourceName;
    }
  }
}