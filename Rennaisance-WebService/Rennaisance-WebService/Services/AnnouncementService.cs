using Rennaisance_WebService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rennaisance_WebService.Models;

namespace Rennaisance_WebService.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private IAnnouncementDao announcementDao;

        public void CreateNewAnnouncement(Announcement entity)
        {
            //do some other processing
            announcementDao.Save(entity);
        }

        public void DeleteAnnouncement(Announcement entity)
        {
            //do other processing
            announcementDao.Delete(entity);
        }

        public IList<Announcement> GetAllAnnouncements()
        {
            //do other processing
            return announcementDao.GetAll();
        }

        public Announcement GetAnnouncement(string id)
        {
            //do other processing
            return announcementDao.Get(id);
        }
    }
}