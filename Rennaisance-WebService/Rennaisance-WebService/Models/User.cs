using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RennaisanceWebService.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; } //may need to remove this
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual DateTime DateCreated { get; set; }
    }
}