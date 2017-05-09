using RennaisanceWebService.Hibernate;
using RennaisanceWebService.Models;
using Spring.Transaction.Interceptor;
using System.Collections.Generic;

namespace RennaisanceWebService.Services
{
    public class AnnouncementService
    {
        private AnnouncementDAO _repository;

       public AnnouncementService()
        {
            _repository = new AnnouncementDAO();
        }

        [Transaction]
        public virtual IList<AnnouncementDTO> GetAllAnnouncements()
        {
            return _repository.GetAnnouncements();
        }

        [Transaction]
        public virtual AnnouncementDTO GetAnnouncement(long id)
        {
            return _repository.LoadById(id);
        }

        [Transaction]
        public virtual void SaveAnnouncement(AnnouncementDTO announcement)
        {         
            _repository.InsertAnnouncement(announcement);
        }

        [Transaction]
        public virtual void DeleteAnnouncement(AnnouncementDTO announcement)
        {
            _repository.DeleteById(announcement.Id);
        }

        [Transaction]
        public virtual void UpdateAnnouncement(AnnouncementDTO announcement)
        {
            _repository.Update(announcement);
        }

        public virtual IList<AnnouncementDTO> GetAnnouncementByType(string type)
        {
            return _repository.LoadAnnouncementsByType(type);
        }
    }
}