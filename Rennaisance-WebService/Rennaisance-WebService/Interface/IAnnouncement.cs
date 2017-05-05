using RennaisanceWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennaisance_WebService.Interface
{
    public interface IAnnouncement
    {
        int Id { get; set; }
        string Title { get; set; }
        string Type { get; set; }
        DateTime Time { get; set; }
        int UserId { get; set; }
        User User { get; set; }
        DateTime DateCreated { get; set; }
    }
}
