using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gehege
    {
        private int g_id;
        private double groesse;
        private int k_id;
        private string name;

        public int G_id { get => g_id; set => g_id = value; }
        public double Groesse { get => groesse; set => groesse = value; }
        public int K_id { get => k_id; set => k_id = value; }
        public string Name { get => name; set => name = value; }

        public Gehege() { }
        public Gehege(int gid, string na, double g, int kid)
        {
            g_id = gid;
            groesse = g;
            k_id = kid;
            name = na;
        }
    }
}
