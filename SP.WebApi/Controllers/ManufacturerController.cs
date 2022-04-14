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
    public class ManufacturerController : ApiController
    {

        private ManufacturerService CreateManufacturerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var manufactuerService = new ManufacturerService(userId);
            return manufactuerService;
        }
        
        public IHttpActionResult Get()
        {
            ManufacturerService mService = CreateManufacturerService();
            var Manufactuers = mService.GetManufacturers();
            return Ok(Manufactuers);
        }

        public IHttpActionResult Get(int id)
        {
            ManufacturerService mService = CreateManufacturerService();
            var Manufacturers = mService.GetManufacturerById(id);
            return Ok(Manufacturers);
        }

        public IHttpActionResult Post(ManufacturerCreate manufacturer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateManufacturerService();

            if (!service.CreateManufacturer(manufacturer))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(ManufacturerEdit manufacturer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateManufacturerService();

            if (!service.UpdateManufacturer(manufacturer))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateManufacturerService();

            if (!service.DeleteManufacturer(id))
                return InternalServerError();

            return Ok();
        }
    }
}
