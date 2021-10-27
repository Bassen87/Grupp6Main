using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml.Serialization;
using System.IO;
using DataAccessLayer.Exceptions;
using PresentationLayer6.Models;

namespace DataAccessLayer
{
    //Är internal för att inte visas till BL
    //Endast tillgänglig inom klassbibloteket.
    internal class SerializerForXml
    {
        public void Serialize(List<Feed> personList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream outFile = new FileStream("Persons.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, personList);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Persons.xml", "Could not serialize to the file");
            }
        }

        public List<Feed> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream inFile = new FileStream("Persons.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Feed>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Persons.xml", "Could not deserialize the file.");
            }

        }
    }
}
