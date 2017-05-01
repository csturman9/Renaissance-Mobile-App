using Rennaisance_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rennaisance_WebService.Interface
{
    public interface IAppointmentDAO : IDao<Appointment, string>, ISupportsSave<Appointment, string>, ISupportsDeleteDao<Appointment>
    {

    }
}