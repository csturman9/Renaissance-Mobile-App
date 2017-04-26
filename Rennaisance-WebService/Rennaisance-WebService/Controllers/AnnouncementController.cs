using Rennaisance_WebService.Models;
using Rennaisance_WebService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rennaisance_WebService.Controllers
{
    public class AnnouncementController : ApiController
    {
        AnnouncementService Service { get; set; }

        // GET: api/Announcement
        public IEnumerable<Announcement> Get()
        {
            return Service.GetAllUsers();
        }

        // GET: api/Announcement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Announcement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Announcement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Announcement/5
        public void Delete(int id)
        {
        }
    }
}
