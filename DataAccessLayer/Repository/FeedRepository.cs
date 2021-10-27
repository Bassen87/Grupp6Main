using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using PresentationLayer6.Models;

namespace DataAccessLayer.Repository
{
    public class FeedRepository: IRepository<Feed>
    {
        SerializerForXml dataManager;
        List<Feed> listaAvFeeds;
        public FeedRepository()
        {
            dataManager = new SerializerForXml();
            listaAvFeeds = new List<Feed>();
            listaAvFeeds = GetAll();
        }

        public void Create(Feed entity)
        {
            listaAvFeeds.Add(entity);
            SaveChanges();
        }
        public void Delete(int index)
        {
            listaAvFeeds.RemoveAt(index);
            SaveChanges();
        }

        public List<Feed> GetAll()
        {
            List<Feed> listOfPersonsDeserialized = new List<Feed>();
            try
            {
                listOfPersonsDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {


            }

            return listOfPersonsDeserialized;
        }



        public void SaveChanges()
        {
            dataManager.Serialize(listaAvFeeds);
        }

        public void Update(int index, Feed entity)
        {
            if (index >= 0)
            {
                listaAvFeeds[index] = entity;
            }
            SaveChanges();// vid serializering av lisan ska ändringar sparas.
        }

        // Denna metod finns i IPersonRepository interface 
        //public Feed GetByName(string name)
        //{
        //    //GetAll() anropas --> retunerar en lista med återskapade ...
        //    //...objekt från deserialize processen 
        //    //Går igneom en loop för att gämföra och se om parametern namn finns i listan
        //    return GetAll().FirstOrDefault(p => p.Name.Equals(name));
        //}
        //// Denna metod finns i IPersonRepository interface 
        //public Person GetByAddress(string address)
        //{
        //    return GetAll().FirstOrDefault(p => p.Address.Equals(address));
        //}
        //// Denna metod finns i IPersonRepository interface 
        //public int GetIndex(string name)
        //{
        //    return GetAll().FindIndex(e => e.Name.Equals(name));
        //}
    }
}
