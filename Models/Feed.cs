using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PresentationLayer6.Models
{

    [XmlInclude(typeof(Podcast))]
    public abstract class Feed
    {
        public string Uid { get; set; }
        public string Namn { get; set; }
        public Kategori Kategori { get; set; }
        public string Url { get; set; }
        public String FeedTitel { get; set; }
        public String FeedKategorier { get; set; }
        public String FeedLank { get; set; }
        public String feedMapp { get; set; }
        public int FeedUpdateIntervall { get; set; }
        public List<Avsnitt> AvsnittsLista { get; set; }

        //Set in seconds
        public uint UppdateringsIntervall { get; set; }

        public Feed()
        {

        }

        public Feed(string uid, string namn, Kategori kategori, string url, uint uppdateringsIntervall)
        {
            Namn = namn;
            Uid = uid;
            Kategori = kategori;
            Url = url;
            UppdateringsIntervall = uppdateringsIntervall;
        }

        public virtual string HamtaInfo()
        {
            return "";
        }
    }
}
