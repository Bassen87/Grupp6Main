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

        public Podcast(string uid, string namn, Kategori kategori, string url, uint updateInterval) : base(uid, namn, kategori, url, updateInterval)
        {

        }

        public override string HamtaInfo()
        {
            return $"{Namn} \n{Kategori.Namn} \nUppdateringsintervall: {UppdateringsIntervall}s \nAntal avsnitt: {Avsnitt.Count}";
        }

        public string DisplayInfo => HamtaInfo();

    
        }
    }