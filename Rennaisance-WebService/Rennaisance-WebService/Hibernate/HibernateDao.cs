using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RennaisanceWebService.Hibernate
{
    public abstract class HibernateDao
    {
        private ISessionFactory sessionFactory;

        public ISessionFactory SessionFactory
        {
            protected get { return sessionFactory; }
            set { sessionFactory = value; }
        }

        protected ISession CurrentSession
        {
            get { return sessionFactory.GetCurrentSession(); }
        }

        protected IList<T> GetAll<T>() where T : class
        {
            ICriteria criteria = CurrentSession.CreateCriteria<T>();
            return criteria.List<T>();
        }
    }
}