using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilhandler
{
    internal class Varevogn
    {
        public string? Navn { get; set; }
        public int Pris { get; set; }
        public int År { get; set; }

        public int Km { get; set; }


        public List<Varevogn> VarevogneList { get; set; } = new();


    }

}
