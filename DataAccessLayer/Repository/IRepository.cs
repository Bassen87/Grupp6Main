using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(string uid, T newEntity);
        void Delete(string uid);
        void Save();
        List<T> GetAll();
        T Find(Predicate<T> match);

    }
}
