using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Futter
    {
        private int f_id;
        private string bezeichnung;
        private string verpackung;

        public int F_id { get => f_id; set => f_id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public string Verpackung { get => verpackung; set => verpackung = value; }

        public Futter() { }
        public Futter(int fid, string bez, string ver)
        {
            f_id = fid;
            bezeichnung = bez;
            verpackung = ver;

        
        }


    }
}
