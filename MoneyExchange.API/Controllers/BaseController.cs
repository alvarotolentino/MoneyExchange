using Microsoft.AspNetCore.Mvc;

namespace MoneyExchange.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public abstract class BaseController: ControllerBase
    {
    }
}
