using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Domain
{
    public interface IDataRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Delete(long id);
        void Update(TEntity entity);
    }
}
