using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tierart
    {
        private int ta_id;
        private string bezeichnung;

        public int Ta_id { get => ta_id; set => ta_id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public Tierart() { }

        public Tierart(int tid, string bez)
        {
            ta_id = tid;
            bezeichnung = bez;
        }

    }
}
