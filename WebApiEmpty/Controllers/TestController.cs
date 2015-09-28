using System.Web.Http;

namespace WebApiEmpty.Controllers
{
    public class TestController : ApiController
    {
        public int Get()
        {
            return 1000;
        }
    }
}
