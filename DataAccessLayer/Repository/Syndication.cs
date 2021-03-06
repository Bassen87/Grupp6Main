
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using PresentationLayer6.Models;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer.Repository
{
    public class Syndication

    {
        public async Task<List<Avsnitt>> LasAvsnitt(string avsnittLink);
        XmlReader reader = XmlReader.Create(avsnittLink);
        SyndicationFeed feed = SyndicationFeed.Load(reader);
        List<Avsnitt> listaAvAvsnitt = new List<Avsnitt>();
        foreach (var item in feed.Items){
            
            var avsnitt = new Avsnitt();
            Avsnitt.AvsnittTitel = item.Titel.Text;
            Avsnitt.AvsnittBeskrivning = item.Beskrivning.Text;
            Avsnitt.datum = item.PubliceringsDatum.ToString();
            ListaAvAvsnitt.Add(avsnitt);

    }
        return ListaAvAvsnitt;
        await LasAvsnitt(avsnittLink);

}

    public async Task LaggTillInfo(string url, string feedLank, int uppdateringsIntervall, String feedMapp, string feedTitel, string kategoriNamn)
{
    var feed = new Feeds
    {
        FeedTitel = feedTitel,
        FeedKategorier = kategoriNamn,
        FeedLank = feedLank,
        FeedUppdateringsIntervall = uppdateringsIntervall,
        feedMapp = feedMapp,
        AvsnittsLista = await LasAvsnitt(feedLink)
    };
    sparaDataTillXml(feed);
}

    public void sparaDataTillXml(Feeds oneFeed)
{
    XmlSerializer nySerializering = new XmlSerializer(typeof(Feeds));
    using (StreamWriter writer = new StreamWriter(oneFeed.feedFolder))
    {
        nySerializering.Serialize(writer, oneFeed);
        writer.Close();
    }
}

}
