using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PresentationLayer6.Models
{
    public class Avsnitt
    {
        [XmlElement(ElementName = "titel")]
        public string Title { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public DateTime PublishedDate { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }


        public String AvsnittTitel { get; set; }
        public String AvsnittLink { get; set; }
        public String AvsnittBeskrivning { get; set; }
        public string datum { get; set; }

    }
}