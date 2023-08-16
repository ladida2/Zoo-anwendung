using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class vkonge
    {
        private string gname;
        private string kname;

        public string Gname { get => gname; set => gname = value; }
        public string Kname { get => kname; set => kname = value; }

        public vkonge() { }

        public vkonge(string gna, string kna )
        {
            gname = gna;
            kname = kna;

        }
    }
}
