using System.Web.Http;

namespace CSharpWebApi.Controllers
{
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("health")]
        public IHttpActionResult Get()
        {
            return Ok(new { status = "healthy" });
        }
    }
}
