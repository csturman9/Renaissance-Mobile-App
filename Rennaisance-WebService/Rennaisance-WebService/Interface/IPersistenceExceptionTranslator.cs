using Spring.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennaisance_WebService.Interface
{
    public interface IPersistenceExceptionTranslator
    {
        DataAccessException TranslateExceptionIfPossible(Exception ex);

    }
}
