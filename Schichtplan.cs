using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Schichtplan
    {
        private int p_id;
        private int gh_id;
        private bool rolle;
        private bool schicht;

        public int P_id { get => p_id; set => p_id = value; }
        public int Gh_id { get => gh_id; set => gh_id = value; }
        public bool Rolle { get => rolle; set => rolle = value; }
        public bool Schicht { get => schicht; set => schicht = value; }

        public Schichtplan() { }
        public Schichtplan(int pid, int ghid, bool ro, bool schi)
        {
            p_id = pid;
            gh_id = ghid;
            rolle = ro;
            schicht = schi;

        
        }


    }
}
