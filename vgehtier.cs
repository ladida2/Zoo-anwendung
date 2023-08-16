using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class vgehtier
    {
        private string gname;
        private string tname;

        public string Gname { get => gname; set => gname = value; }
        public string Tname { get => tname; set => tname = value; }

        public vgehtier() { }
        public vgehtier(string gna, string tna)
        {
            gname = gna;
            tname = tna;

        }
    }
}
