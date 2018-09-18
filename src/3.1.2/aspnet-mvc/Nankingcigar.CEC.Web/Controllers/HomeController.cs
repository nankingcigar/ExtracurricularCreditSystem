using System.Web.Mvc;

namespace Nankingcigar.CEC.Web.Controllers
{
  public class HomeController : CECControllerBase
  {
    public ActionResult Index()
    {
      return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
    }
  }
}