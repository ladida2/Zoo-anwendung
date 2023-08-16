using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Zoo
{
    public partial class Tiersuche : Form
    {
        
        private List<Tier> lit1;
        private Datenbank db = new Datenbank();
        public Tiersuche()
        {
            InitializeComponent();
           
        }
        private void Fotoanzeigen1(int index)
        {
            string dateiname = "Images\\" + lit1[index].T_name + ".jpg";


            if (File.Exists(dateiname))
            {
                pictureBox2.Image = Image.FromFile(dateiname);

            }
            else pictureBox2.Image = null;
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void btnSuche_Click_1(object sender, EventArgs e)
        {
            lBGefunden.Items.Clear();

            lit1 = db.getsucheTier(tBSuche.Text);

            foreach (Tier t in lit1)
            {
                lBGefunden.Items.Add(t.T_name);
            }
        }

        private void lBGefunden_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Fotoanzeigen1(lBGefunden.SelectedIndex);
        }

        
    }
}
