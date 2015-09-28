using System.Web.Http;

namespace WebApiEmpty.Controllers
{
    public class TestController : ApiController
    {
        public int Get(int id)
        {
            return id;
        }
    }
}
