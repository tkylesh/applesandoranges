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
    [RoutePrefix("api/orange")]
    public class OrangeController : ApiController
    {
        readonly IOrangeRepo _orangerepo;

        public OrangeController()
        {
            _orangerepo = new OrangeRepo();
        }

        public OrangeController(IOrangeRepo repo)
        {
            _orangerepo = repo;
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage getOrangeById(int id)
        {
            var orange = _orangerepo.GetOrangeById(id);

            if (orange == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Orange with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, orange);
        }
    }
}
