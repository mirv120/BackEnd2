using Microsoft.AspNetCore.Mvc;

namespace BackEnd2;

[Route("api/[controller]")]
[ApiController]
public class BackEnd2Controller : ControllerBase
{
    private const int BackEnd2Result = 117;

    [HttpGet]
    public int GetBackEndResult()
    {
        return BackEnd2Result;
    }

    [HttpPost]
    public ActionResult WriteBackEndData(int valueToPost)
    {
        if (valueToPost == BackEnd2Result)
        {
            return Ok();
        }
        return BadRequest("Posted value did not match");
    }
}
