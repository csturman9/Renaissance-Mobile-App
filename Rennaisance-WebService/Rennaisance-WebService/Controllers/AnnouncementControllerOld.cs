using RennaisanceWebService.Models;
using RennaisanceWebService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Rennaisance_WebService.Controllers
{
    public class AnnouncementControllerOld : ApiController
    {
        public AnnouncementService Service
        {
            get;
            set;
        }

        [HttpGet]
        // GET: api/Announcement
        public IList<Announcement> Get()
        {
            return Service.GetAllAnnouncements();
        }

        // GET: api/Announcement/5
        public Announcement Get(string id)
        {
            return Service.GetAnnouncement(id);
        }

        // POST: api/Announcement
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Announcement value)
        {
            try
            {
                Service.Save(value);
                var response = Request.CreateResponse<Announcement>(HttpStatusCode.Created, value);

                string uri = Url.Link("DefaultApi", new { id = value.Id });
                response.Headers.Location = new Uri(uri);
                return response;

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPut]
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

        [HttpDelete]
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
