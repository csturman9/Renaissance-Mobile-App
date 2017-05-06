using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace RennaisanceWebService.Models
{
    [DataContract]
    public class AnnouncementDTO : BaseDTO<Int64>
    {
        public AnnouncementDTO()
        {
            Host = new UserDTO();
        }

        [DataMember]
        public virtual string Title { get; set; }

        [DataMember]
        public virtual string Type { get; set; }

        [DataMember]
        public virtual DateTime EventTime { get; set; }

        [DataMember]
        public virtual string UpdatedBy { get; set; }

        [DataMember]
        public virtual DateTime UpdateDate { get; set; }

        [DataMember]
        public virtual string Sermon { get; set; }

        [DataMember]
        public virtual string Hymns { get; set; }

        [DataMember]
        public virtual string AdditionalInfo { get; set; }

        [IgnoreDataMember]
        [XmlIgnore]
        public virtual UserDTO Host { get; set; }
    }

    public enum AnnouncementType
    {
        WEEKLY,
        SERVICE
    }
}