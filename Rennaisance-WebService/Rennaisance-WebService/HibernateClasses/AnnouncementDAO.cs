using NHibernate.Util;
using RennaisanceWebService.Models;
using System;
using System.Collections.Generic;

namespace RennaisanceWebService.Hibernate
{
    public class AnnouncementDAO : BaseDAO<AnnouncementDTO,Int64>
    {
        public void DeleteByTitle(String title)
        {
            var queryResult = CurrentSession.QueryOver<AnnouncementDTO>()
                              .Where(p => p.Title == title);

            if (queryResult != null && queryResult.RowCount() > 0)
            {
                IList<AnnouncementDTO> peopleToBeDeleted = queryResult.List();
                peopleToBeDeleted.ForEach(personToBeDeleted => CurrentSession.Delete(personToBeDeleted));
                CurrentSession.Flush();
            }
        }




        //[Transaction(ReadOnly = false)]
        //public void Delete(AnnouncementDTO entity)
        //{
        //    CurrentSession.Delete(entity);
        //}

        //[Transaction(ReadOnly = true)]
        //public AnnouncementDTO Get(string id)
        //{
        //    return CurrentSession.Get<AnnouncementDTO>(id);
        //}

        //[Transaction(ReadOnly = true)]
        //public IList<AnnouncementDTO> GetAll()
        //{
        //    return GetAll<AnnouncementDTO>();
        //}

        //[Transaction(ReadOnly = false)]
        //public string Save(AnnouncementDTO entity)
        //{
        //    return (string)CurrentSession.Save(entity);
        //}

        //[Transaction(ReadOnly = false)]
        //public void Update(AnnouncementDTO entity)
        //{
        //    CurrentSession.SaveOrUpdate(entity);
        //}
    }
}