using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    {
        public string Uid { get; set; }
        public string Name { get; set; }

        public Kategori()
        {

        }
        public Kategori(string uid, string name)
        {
            Uid = uid;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}