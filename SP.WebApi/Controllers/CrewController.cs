using Microsoft.AspNet.Identity;
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
    [Authorize]
    public class CrewController : ApiController
    {
        public IHttpActionResult Get()
        {
            CrewService crewService = CreateCrewService();
            var crews = crewService.GetCrews();
            return Ok(crews);
        }

        public IHttpActionResult Get(int id)
        {
            CrewService crewService = CreateCrewService();
            var crew = crewService.GetCrewsById(id);
            return Ok(crew);
        }

        public IHttpActionResult Post(CrewCreate crew)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateCrewService();

            if (!service.CreateCrew(crew))
            {
                return InternalServerError();
            }
            return Ok();
        }

        private CrewService CreateCrewService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var crewService = new CrewService(userId);
            return crewService;

        }
    }
}
