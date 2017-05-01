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
    public class HibernateAppointmentDao : HibernateDao, IAppointmentDAO
    {
        [Transaction(ReadOnly = false)]
        public void Delete(Appointment entity)
        {
            CurrentSession.Delete(entity);
        }

        [Transaction(ReadOnly = true)]
        public Appointment Get(string id)
        {
            return CurrentSession.Get<Appointment>(id);
        }

        [Transaction(ReadOnly = true)]
        public IList<Appointment> GetAll()
        {
            return GetAll<Appointment>();
        }

        [Transaction(ReadOnly = false)]
        public string Save(Appointment entity)
        {
            return (string)CurrentSession.Save(entity);
        }

        [Transaction(ReadOnly = false)]
        public void Update(Appointment entity)
        {
            CurrentSession.SaveOrUpdate(entity);
        }

    }
}