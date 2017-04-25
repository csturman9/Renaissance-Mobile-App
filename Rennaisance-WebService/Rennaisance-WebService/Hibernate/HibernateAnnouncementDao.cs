using Rennaisance_WebService.Interface;
using Rennaisance_WebService.Models;
using Spring.Stereotype;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Hibernate
{
    [Repository]
    public class HibernateAnnouncementDao : HibernateDao, IAnnouncementDao
    {
        [Transaction(ReadOnly = false)]
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

        [Transaction(ReadOnly = false)]
        public string Save(Announcement entity)
        {
            return (string) CurrentSession.Save(entity);
        }

        [Transaction(ReadOnly = false)]
        public void Update(Announcement entity)
        {
            CurrentSession.SaveOrUpdate(entity);
        }
    }
}