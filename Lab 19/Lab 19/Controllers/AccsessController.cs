
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Laboratorio19.Models.WS;

namespace Lab_19.Controllers
{
    public class AccsessController : ApiController
    {
        [HttpGet]
        public Replay Helloworld()
        {
            Replay oR = new Replay();
            oR.result = 1;
            oR.message = "mi Hello World en API";
            return oR;
        }
    }
}

namespace Laboratorio19.Models.WS
{
    public class Replay
    {
        public int result { get; set; }
        public string message { get; set; }
    }
}
