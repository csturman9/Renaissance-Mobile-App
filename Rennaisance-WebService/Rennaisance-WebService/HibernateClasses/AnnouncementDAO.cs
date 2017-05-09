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

        public void InsertAnnouncement(AnnouncementDTO dto)
        {
            if(dto.Host != null)
            {
                CurrentSession.Save(dto.Host);
            }
            Create(dto);
        }

        public AnnouncementDTO GetAnnouncementById(long id)
        {
            var announcement = LoadById(id);
            return announcement;
        }

        public IList<AnnouncementDTO> GetAnnouncements()
        {       
            var announcements = LoadAll();
            return announcements;
        }

        public IList<AnnouncementDTO> LoadAnnouncementsByType(String type)
        {
            return CurrentSession
                    .CreateQuery("from AnnouncementDTO announcement where announcement.Type=?")
                    .SetParameter(0, type)
                    .List<AnnouncementDTO>();
        }

        public void SaveAnnouncement(AnnouncementDTO dto)
        {
            if (dto.Host != null)
            {
                CurrentSession.SaveOrUpdate(dto.Host);
            }
            SaveOrUpdate(dto);
        }

    }
}