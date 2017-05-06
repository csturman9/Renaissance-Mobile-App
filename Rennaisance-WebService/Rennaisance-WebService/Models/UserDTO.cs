using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RennaisanceWebService.Models
{
    [DataContract]
    public class UserDTO : BaseDTO<Int64>
    {
      
        [DataMember]
        public virtual string FirstName { get; set; }

        [DataMember]
        public virtual string LastName { get; set; }

        [DataMember]
        public virtual string Phone { get; set; }

        [DataMember]
        public virtual string Email { get; set; }

        [DataMember]
        public virtual string Address { get; set; }

        [DataMember]
        public virtual DateTime DateCreated { get; set; }
    }
}