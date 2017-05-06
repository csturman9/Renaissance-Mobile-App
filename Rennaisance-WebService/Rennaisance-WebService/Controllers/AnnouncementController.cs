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

    }
}
