using RennaisanceWebService.Interface;
using RennaisanceWebService.Models;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RennaisanceWebService.Services
{
    public class AnnouncementService
    {
        private IAnnouncementDao announcementDao;

        public IAnnouncementDao AnnouncementDao
        {
            get
            {
                return announcementDao;
            }
            set
            {
                announcementDao = value;
            }
        }

        [Transaction]
        public virtual IList<Announcement> GetAllAnnouncements()
        {
            return AnnouncementDao.GetAll();
        }

        [Transaction]
        public virtual Announcement GetAnnouncement(string id)
        {
            return AnnouncementDao.Get(id);
        }

        [Transaction]
        public virtual void Save(Announcement announcement)
        {
            AnnouncementDao.Save(announcement);
        }

        [Transaction]
        public virtual void DeleteAnnouncement(Announcement announcement)
        {
            AnnouncementDao.Delete(announcement);
        }

        [Transaction]
        public virtual void UpdateAnnouncement(Announcement announcement)
        {
            AnnouncementDao.Update(announcement);
        }
    }
}