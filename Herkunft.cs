using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Herkunft
    {
        private int h_id;
        private string woher;

        public int H_id { get => h_id; set => h_id = value; }
        public string Woher { get => woher; set => woher = value; }

        public Herkunft() { }
        public Herkunft(int hid, string wo)
        { 
            h_id = hid;
            woher = wo; 
        }

    }
}
