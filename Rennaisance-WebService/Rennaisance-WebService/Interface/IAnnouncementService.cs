using Rennaisance_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennaisance_WebService.Interface
{
    public interface IAnnouncementService
    {
        void CreateNewAnnouncement(Announcement entity);
        void DeleteAnnouncement(Announcement entity);
        Announcement GetAnnouncement(string id);
        IList<Announcement> GetAllAnnouncements();

    }
}
