using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tierfutter
    {
        private int t_id;
        private int f_id;
        private string menge;

        public int T_id { get => t_id; set => t_id = value; }
        public int F_id { get => f_id; set => f_id = value; }
        public string Menge { get => menge; set => menge = value; }

        public Tierfutter(){ }

        public Tierfutter(int tid, int fid, string me) 
        {
            t_id = tid;
            f_id = fid;
            menge = me;

        }
    }
}
