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
    
    public class ShipController : ApiController
    {
        
        private ShipService CreateShipService()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            var shipService = new ShipService(); //(userId);
            return shipService;
        }

        public IHttpActionResult Get()
        {
            ShipService shipService = CreateShipService();
            var ships = shipService.GetShips();
            return Ok(ships);
        }

        public IHttpActionResult Get(int id)
        {
            ShipService shipService = CreateShipService();
            var ship = shipService.GetShipById(id);
            return Ok(ship);
        }
        
        public IHttpActionResult Post(ShipCreate ship)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateShipService();

            if (!service.CreateShip(ship))
                return InternalServerError();

            return Ok();
        }
        
        public IHttpActionResult Put(ShipEdit ship)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateShipService();

            if (!service.UpdateShip(ship))
                return InternalServerError();

            return Ok();
        }
        
        public IHttpActionResult Delete(int id)
        {
            var service = CreateShipService();

            if (!service.DeleteShip(id))
                return InternalServerError();

            return Ok();
        }
    }
}
