using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class vfuergrid
    {
        private string tname;
        private string kname;
        private string gname;

        public string Tname { get => tname; set => tname = value; }
        public string Kname { get => kname; set => kname = value; }
        public string Gname { get => gname; set => gname = value; }


        public vfuergrid() { }
        public vfuergrid(string tna, string kna, string gna) 
        {
            tname = tna;
            kname = kna;
            gname = gna;
        }
    }
}
