using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RennaisanceWebService.Models
{
    public abstract class Announcement
    {
        public Announcement()
        {

        }

        int id;
        string title;
        string type;
        DateTime time;
        int userId;
        User user;
        DateTime dateCreated;

        public int Id
        {
            get => Id;
            set => Id = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Type
        {
            get => type;
            set => type = value;
        }

        public DateTime Time
        {
            get => time;
            set => time = value;
        }
        public int UserId
        {
            get => userId;
            set => userId = value;
        }
        public User User
        {
            get => user;
            set => user = value;
        }
        public DateTime DateCreated
        {
            get => DateCreated;
            set => DateCreated = value;
        }
    }

    public enum AnnouncementType
    {
        WEEKLY,
        SERVICE
    }

    public class GeneralAnnouncement : Announcement
    {
        string topic;
        string message;
        string additonalInformation;

        public string Topic
        {
            get => topic;
            set => topic = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        public string AdditonalInformation
        {
            get => additonalInformation;
            set => additonalInformation = value;
        }
    }

    public class ServiceAnnouncement : Announcement
    {
        List<string> bibleVerses;
        List<string> songs;
        List<string> speakers;

        public List<string> BibleVerses
        {
            get => bibleVerses;
            set => bibleVerses = value;
        }
        public List<string> Songs
        {
            get => songs;
            set => songs = value;
        }
        public List<string> Speakers
        {
            get => speakers;
            set => speakers = value;
        }
    }
}