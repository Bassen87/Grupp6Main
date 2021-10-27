using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer6.Models
{
    public class Kategori
    {
        public string Uid { get; set; }
        public string Namn { get; set; }

        public Kategori()
        {

        }
        public Kategori(string uid, string namn)
        {
            Uid = uid;
            Namn = namn;
        }

        public override string ToString()
        {
            return Namn;
        }
    }
}