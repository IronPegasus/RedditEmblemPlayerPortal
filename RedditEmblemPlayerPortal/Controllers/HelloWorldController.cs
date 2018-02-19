using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RedditEmblemPlayerPortal.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  public class HelloWorldController : Controller
  {
    [HttpGet]
    [Route("Say")]
    public string Say()
    {
      return "Hello World! This is your Angular app.";
    }
  }
}