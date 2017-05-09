using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rennaisance_WebService.Interface;
using Rennaisance_WebService.Models;
using Spring.Transaction.Interceptor;

namespace Rennaisance_WebService.Services
{
    public class AppointmentService
    {
        private IAppointmentDAO appointmentDao;

        public IAppointmentDAO AppointmentDao
        {
            get
            {
                return appointmentDao;
            }

            set
            {
                AppointmentDao = value;
            }
        }

        [Transaction]
        public virtual IList<Appointment> GetAllAppointments()
        {
            return AppointmentDao.GetAll();
        }

        [Transaction]
        public virtual Appointment GetAppointment(string id)
        {
            return AppointmentDao.Get(id);
        }

        [Transaction]
        public virtual void Save(Appointment appointment)
        {
            AppointmentDao.Save(appointment);
        }

        [Transaction]
        public virtual void DeleteAppoitnment(Appointment appointment)
        {
            AppointmentDao.Delete(appointment);
        }

        [Transaction]
        public virtual void UpdateAppointment(Appointment appointment)
        {
            appointmentDao.Update(appointment);
        }
    }
}