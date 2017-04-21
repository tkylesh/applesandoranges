using applesandoranges.Api.Contracts;
using applesandoranges.Api.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace applesandoranges.Api.Controllers
{
    [RoutePrefix("api/apple")]
    public class AppleController : ApiController
    {
        readonly IAppleRepo _applerepo;

        public AppleController()
        {
            _applerepo = new AppleRepo();
        }

        public AppleController(IAppleRepo repo)
        {
            _applerepo = repo; 
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage getAppleById(int id)
        {
            var apple = _applerepo.GetAppleById(id);

            if (apple == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Apple with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, apple);
        }
    }
}
