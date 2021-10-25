using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast : Feed
    {
        public List<Avsnitt> Avsnitt;

        public Podcast()
        {

        }

        public Podcast(string uid, string name, Kategori kategori, string url, uint updateInterval) : base(uid, name, kategori, url, updateInterval)
        {

        }

        public override string GetInfo()
        {
            return $"{Name} \n{Kategori.Name} \nUppdateringsintervall: {UpdateInterval}s \nAntal avsnitt: {Avsnitt.Count}";
        }

        public string DisplayInfo => GetInfo();
    }
}