using Microsoft.AspNetCore.Mvc;
namespace backend.Controllers
{
  [Route("api")]
  [ApiController]
  public class FrontEndController : ControllerBase
  {
    [Route("FrontEnd")]
    [HttpGet]
    public IActionResult FrontEnd()
    {
      return Ok();
    }
  }
}
