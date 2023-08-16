using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tier
    {
        private int t_id;
        private string t_name;
        private string gebdat;
        private int ta_id;
        private int gh_id;
        private int h_id;

        public int T_id { get => t_id; set => t_id = value; }
        public string T_name { get => t_name; set => t_name = value; }
        public string Gebdat { get => gebdat; set => gebdat = value; }
        public int Ta_id { get => ta_id; set => ta_id = value; }
        public int Gh_id { get => gh_id; set => gh_id = value; }
        public int H_id { get => h_id; set => h_id = value; }

        public Tier() { }

        public Tier(int tid,  string gebdat, int taid, int ghid, int hid, string na)
        {
            t_id = tid;
            t_name = na;
            this.gebdat = gebdat;
            ta_id = taid;
            gh_id = ghid;
            h_id = hid;
        }
    }
}
