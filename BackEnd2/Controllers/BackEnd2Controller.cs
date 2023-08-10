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
}
