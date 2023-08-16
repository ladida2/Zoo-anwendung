using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Zoo
{
    public partial class Themen_und_Gehege : Form
    {
        private Datenbank db = new Datenbank();
        List<Gehege> lige;
        List<Kontinente> liko;
        List<vgehtier> ligt;
        List<vkonge> likg;
        public Themen_und_Gehege()
        {
            InitializeComponent();
            GehegeAnzeigen();
            KontinenteAnzeigen();
        }
        private void clearFieldsGehege()
        {
            tBGehegeID.Text = "";
            tBGehegeGroesse.Text = "";
            tBGehegeName.Text = "";
            cBGehegeKontinent.Text = "";

        }
        // Anzeigen Funktionen
        private void GehegeAnzeigen()
        {

            lige = db.getGehege();
            lBGehege.Items.Clear();
            cBTierGehege.Items.Clear();

            foreach (Gehege ge in lige)
            {
                lBGehege.Items.Add(ge.Name);
                cBTierGehege.Items.Add(ge.Name);
               
            }


        }
        private void KontinenteAnzeigen()
        {

            liko = db.getkontinente();


            foreach (Kontinente ko in liko)
            {
               
                cBThemenGehege.Items.Add(ko.Kname);
                cBGehegeKontinent.Items.Add(ko.Kname);
            }


        }
        // Selected Index Combobox
        private void cBThemenGehege_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lBThemenGehege.Items.Clear();

            likg = db.getkonge();

            if (cBThemenGehege.SelectedIndex != -1)
            {

                foreach (vkonge vkg in likg)
                {
                    if (vkg.Kname == cBThemenGehege.Text)
                        lBThemenGehege.Items.Add(vkg.Gname);

                }

            }

        }
        private void cBTierGehege_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lBGehegeTier.Items.Clear();

            ligt = db.getgehtier();

            if (cBTierGehege.SelectedIndex != -1)
            {

                foreach (vgehtier vgt in ligt)
                {
                    if (vgt.Gname == cBTierGehege.Text)
                        lBGehegeTier.Items.Add(vgt.Tname);

                }

            }
        }
        // Selected Index Listbox
        private void lBGehege_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (lBGehege.SelectedIndex != -1)
            {
                Gehege ge = lige[lBGehege.SelectedIndex];

                tBGehegeID.Text = ge.G_id.ToString();
                tBGehegeGroesse.Text = ge.Groesse.ToString();
                tBGehegeName.Text = ge.Name;
                cBGehegeKontinent.Text = ge.K_id.ToString();

                cBGehegeKontinent.SelectedIndex =
                    liko.FindIndex(x => x.K_id == ge.K_id);
            }
        }
        // Button speichern 
        private void btnSaveGehege_Click(object sender, EventArgs e)
        {
            Gehege ge = new Gehege();


            ge.G_id = -1;
            ge.Groesse = Convert.ToDouble(tBGehegeGroesse.Text);
            ge.Name = tBGehegeName.Text;
            ge.K_id = liko[cBGehegeKontinent.SelectedIndex].K_id;

            db.saveGehege(ge);
            GehegeAnzeigen();
            clearFieldsGehege();
        }
        // Button löschen
        private void btnLöschenGehege_Click(object sender, EventArgs e)
        {

            if (lBGehege.SelectedIndex != -1)
            {
                db.delGehege(Convert.ToInt32(tBGehegeID.Text));
                GehegeAnzeigen();
            }
            clearFieldsGehege();
        }
        // Button update 
        private void btnUpdateGehege_Click(object sender, EventArgs e)
        {
            Gehege ge = new Gehege();

            ge.G_id = Convert.ToInt32(tBGehegeID.Text);
            ge.Groesse = Convert.ToDouble(tBGehegeGroesse.Text);
            ge.Name = tBGehegeName.Text;
            ge.K_id = liko[cBGehegeKontinent.SelectedIndex].K_id;

            db.updateGehege(ge);
            GehegeAnzeigen();
            clearFieldsGehege();
        }
        // Button zurück
        private void btnZurück1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // XML Erstellen
        private void btnGehegeList_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Gehege.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Gehege");

            foreach (Gehege gh in lige)
            {
                writer.WriteStartElement("Gehege");
                writer.WriteAttributeString("GH_ID", gh.G_id.ToString());
                writer.WriteAttributeString("Groesse", gh.Groesse.ToString());
                writer.WriteAttributeString("Kontinent_ID", gh.K_id.ToString());
                writer.WriteAttributeString("Name", gh.Name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        private void btnKontilist_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Kontinente.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Kontinente");

            foreach (Kontinente ko in liko)
            {
                writer.WriteStartElement("Kontinente");
                writer.WriteAttributeString("K_ID", ko.K_id.ToString());
                writer.WriteAttributeString("Name", ko.Kname);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
