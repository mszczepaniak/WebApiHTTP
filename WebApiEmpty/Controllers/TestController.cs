using System;
using System.Web.Http;

namespace WebApiEmpty.Controllers
{
    public class TestController : ApiController
    {
        public class Sample
        {
            public int ID { get; set; }

            public string Description { get; set; }

            public DateTime Date { get; set; }
        }

        public IHttpActionResult Get()
        {
            var sample = new Sample {ID=10, Description = "bla", Date = DateTime.Now};
            return Ok(sample);
        }

        public IHttpActionResult Post()
        {
            return Ok();
        }
    }
}
