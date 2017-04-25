using Spring.Data.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Bytecode;
using Spring.Data.NHibernate.Bytecode;

namespace Rennaisance_WebService.Hibernate
{
    public class  CustomLocalSessionFactoryObject : LocalSessionFactoryObject
    {
        public override IBytecodeProvider BytecodeProvider
        {
            get { return new BytecodeProvider(ApplicationContext); }
            set { }
        }

    }
}
