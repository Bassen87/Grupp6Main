using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{

    [XmlInclude(typeof(Podcast))]
    public abstract class Feed
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public Kategori Kategori { get; set; }
        public string Url { get; set; }

        //Set in seconds
        public uint UpdateInterval { get; set; }

        public Feed()
        {

        }

        public Feed(string uid, string name, Kategori kategori, string url, uint updateInterval)
        {
            Name = name;
            Uid = uid;
            Kategori = kategori;
            Url = url;
            UpdateInterval = updateInterval;
        }

        public virtual string GetInfo()
        {
            return "";
        }
    }
}
