using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Models
{
    public class GeneralAnnouncementDTO
    {
        public virtual string Topic { get; set; }
        public virtual string Message { get; set; }
        public virtual string AdditonalInformation { get; set; }

    }
}