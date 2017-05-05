using RennaisanceWebService.Models;
using RennaisanceWebService.Services;
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

        public IList<Announcement> Get()
        {
            return Service.GetAllAnnouncements();
        }

        // GET: api/Announcement/5
        public Announcement Get(string id)
        {
            return Service.GetAnnouncement(id);
        }

    }
}
