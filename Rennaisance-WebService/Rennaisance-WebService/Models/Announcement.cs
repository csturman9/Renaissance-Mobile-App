using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RennaisanceWebService.Models
{
    public abstract class Announcement
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Type { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime DateCreated { get; set; }
    }

    public enum AnnouncementType
    {
        WEEKLY,
        SERVICE
    }

    public class GeneralAnnouncement : Announcement
    {
        public virtual string Topic { get; set; }
        public virtual string Message { get; set; }
        public virtual string AdditonalInformation { get; set; }

    }

    public class ServiceAnnouncement : Announcement
    {
        public virtual List<string> BibleVerses { get; set; }
        public virtual List<string> Songs { get; set; }
        public virtual List<string> Speakers { get; set; }

    }
}