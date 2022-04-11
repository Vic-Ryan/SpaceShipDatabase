using SP.Models;
using SP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SP.WebApi.Controllers
{
    public class OriginController : ApiController
    {
        private OriginService CreateOriginService()
        {
            
            var originService = new OriginService();
            return originService;
        }

        public IHttpActionResult Get()
        {
            OriginService originService = CreateOriginService();
            var origin = originService.GetOrigin();
            return Ok(origin);
        }

        public IHttpActionResult Post(OriginCreate origin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOriginService();

            if (!service.CreateOrigin(origin))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            OriginService originService = CreateOriginService();
            var origin = originService.GetOriginById(id);
            return Ok();
        }
        public IHttpActionResult Put(OriginEdit origin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOriginService();

            if (!service.UpdateOrigin(origin))
                return InternalServerError();

            return Ok();
        }
    }
}
