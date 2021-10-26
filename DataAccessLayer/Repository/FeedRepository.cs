using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface FeedRepository<T>: IRepository<Feed>
    {
        List<Feed> listaAvFeeds;
        public FeedRepository()
        {
           // dataManager = new SerializerForXml();
            listOfFeeds = new List<Feed>();
            //listOfPersons = GetAll();
        }

        void Create(Feed entity);
        void Update(string uid, T newEntity);
        void Delete(string uid);
        void Save();
        List<T> GetAll();
        T Find(Predicate<T> match);
    }
}
