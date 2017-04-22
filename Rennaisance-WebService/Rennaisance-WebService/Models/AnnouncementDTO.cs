using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Models
{
    public abstract class AnnouncementDTO
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual AnnouncementType Type { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual DateTime DateCreated { get; set; }
    }

    public enum AnnouncementType
    {
        WEEKLY,
        SERVICE
    }
}