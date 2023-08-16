using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Zoo
{
    public class Pfleger
    {
        private int p_id;
        private string vorname;
        private string nachname;

        public int P_id { get => p_id; set => p_id = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }

        public Pfleger() { }

        public Pfleger(int pid, string vor, string nach)
        {
            p_id = pid;
            vorname = vor;
            nachname = nach;

        }

    }
}
