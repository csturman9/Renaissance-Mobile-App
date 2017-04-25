using Rennaisance_WebService.Interface;
using Rennaisance_WebService.Models;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Services
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
        public virtual IList<Announcement> GetAllUsers()
        {
            return AnnouncementDao.GetAll();
        }

        [Transaction]
        public virtual Announcement GetUser(string id)
        {
            return AnnouncementDao.Get(id);
        }

        [Transaction]
        public virtual void Save(Announcement announcement)
        {
            AnnouncementDao.Save(announcement);
        }

        [Transaction]
        public virtual void DeleteUser(Announcement announcement)
        {
            AnnouncementDao.Delete(announcement);
        }

        [Transaction]
        public virtual void UpdateUser(Announcement announcement)
        {
            AnnouncementDao.Update(announcement);
        }
    }
}