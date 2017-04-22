using Rennaisance_WebService.Interface;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Models
{
    public class HibernateAnnouncementDao : HibernateDao, IAnnouncementDao
    {
        [Transaction(ReadOnly = true)]
        public void Delete(Announcement entity)
        {
            CurrentSession.Delete(entity);
        }

        [Transaction(ReadOnly = true)]
        public Announcement Get(string id)
        {
            return CurrentSession.Get<Announcement>(id);
        }

        [Transaction(ReadOnly = true)]
        public IList<Announcement> GetAll()
        {
            return GetAll<Announcement>();
        }

        [Transaction(ReadOnly = true)]
        public string Save(Announcement entity)
        {
            return (string)CurrentSession.Save(entity);
        }

        [Transaction(ReadOnly = true)]
        public void Update(Announcement entity)
        {
            CurrentSession.SaveOrUpdate(entity);
        }
    }
}