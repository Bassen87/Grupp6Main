using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer6.Models;


namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Update(int uid, T newEntity);
        void Delete(int uid);
        void SaveChanges();
        List<T> GetAll();
        //T Find(Predicate<T> match);

    }
}
