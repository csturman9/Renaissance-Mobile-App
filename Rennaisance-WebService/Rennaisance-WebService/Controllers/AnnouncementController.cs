using NHibernate;
using Rennaisance_WebService.Interface;
using Rennaisance_WebService.Models;
using Rennaisance_WebService.Services;
using Spring.Context;
using Spring.Context.Support;
using Spring.Data.NHibernate;
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

        public IEnumerable<Announcement> GetAllProducts()
        {
            return Service.GetAllUsers();
        }

    }
}
