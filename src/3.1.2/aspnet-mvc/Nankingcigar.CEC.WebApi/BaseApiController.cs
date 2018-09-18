using Abp.Dependency;
using Abp.Web.Models;
using Abp.WebApi.Authorization;
using Abp.WebApi.Controllers;
using Nankingcigar.CEC.Core.Extension;

namespace Nankingcigar.CEC
{
  [AbpApiAuthorize, WrapResult]
  public abstract class BaseApiController : AbpApiController, ITransientDependency
  {
    public ICECSession Session { get; set; }
  }
}