using Rennaisance_WebService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Models
{
    public class ServiceAnnouncement : Announcement
    {       
        public virtual List<string> BibleVerses { get; set; }
        public virtual List<string> Songs { get; set; }
        public virtual List<string> Speakers { get; set; }

    }
}