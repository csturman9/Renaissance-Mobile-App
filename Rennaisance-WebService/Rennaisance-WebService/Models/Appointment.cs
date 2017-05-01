using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Models
{
    public abstract class Appointment
    {
        public virtual int Appointmend_Id { get; set; }
        public virtual string Attendee_First_Name { get; set; }
        public virtual string Attendee_Last_Name { get; set;  }
        public virtual string Attendee_Email { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Appointment_Date { get; set; }
        public virtual DateTime Start_Time { get; set; }
        public virtual DateTime End_Time { get; set; }
        public virtual int User_Id { get; set; }
        public virtual string Updated_By { get; set; }
        public virtual DateTime Updated_Date { get; set; }


    }
}