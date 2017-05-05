using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RennaisanceWebService.Interface
{
    public interface IDao<TEntity, TId>
    {
        TEntity Get(TId id);

        IList<TEntity> GetAll();
    }

    public interface ISupportsSave<TEntity, TId>
    {
        TId Save(TEntity entity);

        void Update(TEntity entity);
    }


    public interface ISupportsDeleteDao<TEntity>
    {
        void Delete(TEntity entity);
    }
}
