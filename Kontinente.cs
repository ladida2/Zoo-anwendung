using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Kontinente
    {
        private int k_id;
        private string kname;

        public int K_id { get => k_id; set => k_id = value; }
        public string Kname { get => kname; set => kname = value; }

        public Kontinente() { }
        public Kontinente(int kid, string na)
        {
            k_id = kid;
            kname = na;

        }

    }
}
