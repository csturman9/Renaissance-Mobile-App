using RennaisanceWebService.Models;
using RennaisanceWebService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RennaisanceWebService.Controllers
{
    public class AnnouncementController : ApiController
    {
        public AnnouncementService Service;

        public AnnouncementController()
        {
            Service = new AnnouncementService();
        }     

        public IList<AnnouncementDTO> Get()
        {
            return Service.GetAllAnnouncements();
        }

        // GET: api/Announcement/5
        public AnnouncementDTO Get(long id)
        {
            return Service.GetAnnouncement(id);
        }

        //[HttpPost]
        //public HttpResponseMessage Post([FromBody]AnnouncementDTO value)
        //{
        //    try
        //    {
        //        Service.Save(value);
        //        var response = Request.CreateResponse<AnnouncementDTO>(HttpStatusCode.Created, value);

        //        string uri = Url.Link("DefaultApi", new { id = value.Id });
        //        response.Headers.Location = new Uri(uri);
        //        return response;

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }

        //}

        //[HttpPut]
        //// PUT: api/Announcement/5
        //public HttpResponseMessage Put(long id, [FromBody]AnnouncementDTO value)
        //{
        //    try
        //    {
        //        AnnouncementDTO found = Service.GetAnnouncement(id);
        //        found = value;
        //        Service.Save(found);
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }

        //}

        //[HttpDelete]
        //// DELETE: api/Announcement/5
        //public HttpResponseMessage Delete(long id)
        //{
        //    try
        //    {
        //        AnnouncementDTO toDelete = Service.GetAnnouncement(id);
        //        if (toDelete != null)
        //        {
        //            Service.DeleteAnnouncement(toDelete);
        //            return Request.CreateResponse(HttpStatusCode.OK);
        //        }
        //        else
        //        {
        //            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Could not find Record to delete");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}

    }
}
