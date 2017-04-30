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
        public AnnouncementService Service
        {
            get;
            set;
        }

        // GET: api/Announcement
        public IEnumerable<Announcement> Get()
        {
            return Service.GetAllAnnouncements();
        }

        // GET: api/Announcement/5
        public Announcement Get(string id)
        {
            return Service.GetAnnouncement(id);
        }

        // POST: api/Announcement
        public HttpResponseMessage Post([FromBody]Announcement value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Service.Save(value);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Invalid Model");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        // PUT: api/Announcement/5
        public HttpResponseMessage Put(string id, [FromBody]Announcement value)
        {
            try
            {
                Announcement found = Service.GetAnnouncement(id);
                found = value;
                Service.Save(found);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        // DELETE: api/Announcement/5
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                Announcement toDelete = Service.GetAnnouncement(id);
                if (toDelete != null)
                {
                    Service.DeleteAnnouncement(toDelete);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Could not find Record to delete");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
