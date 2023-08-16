using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Office.Interop.Excel;
using PdfSharp.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Zoo
{
    public partial class Form1 : Form
    {
        private Datenbank db = new Datenbank();
        private XmlReader reader;
       
       
        List<Gehege> lige;
        List<Tierart> lita;
        List<Tier> lit;
        List<Herkunft> lih;
        List<vfuergrid> lifg;
        List<Futter> lifu;
        List<Tierfutter> litiefu;
        List<Pfleger> lipf;
        List<Schichtplan> lisch;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GehegeAnzeigen();
            TierartAnzeigen();
            TierAnzeigen();
            HerkunftAnzeigen();
            fuergridAnzeigen();
            FutterAnzeigen();
            TierfutterAnzeigen();
            PflegerAnzeigen();
            SchichtplanAnzeigen();

        }
        private void clearFieldsTiere()
        {
            tBTierID.Text = "";
            tBTierName.Text = "";
            dateTimePicker1.Text = "";
            cBHerkunftTier.Text = "";
            cBTierartTier.Text = "";
            cBGehegeTier.Text = "";

        }
        private void clearTierart()
        {
            tBTierartID.Text = "";
            tBTierartBezeichnung.Text = "";

        }


        // Anzeige Funktionen
        private void GehegeAnzeigen()
        {

            lige = db.getGehege();
            cBGehegeTier.Items.Clear();
            cBSchichtGehege.Items.Clear();

            foreach (Gehege ge in lige)
            {

                
                cBGehegeTier.Items.Add(ge.Name);
                cBSchichtGehege.Items.Add(ge.Name);
            }


        }
        private void HerkunftAnzeigen()
        {

            lih = db.getHerkunft();


            foreach (Herkunft h in lih)
            {
                cBHerkunftTier.Items.Add(h.Woher);

            }


        }
        private void TierartAnzeigen()
        {

            lita = db.getArten();
            lBArten.Items.Clear();

            foreach (Tierart ta in lita)
            {
                lBArten.Items.Add(ta.Bezeichnung);
                cBTierartTier.Items.Add(ta.Bezeichnung);
                //cBTierartEx.Items.Add(ta.Bezeichnung);
            }


        }
        private void TierAnzeigen()
        {

            lit = db.getTier();
            lBTiere.Items.Clear();

            foreach (Tier t in lit)
            {
                lBTiere.Items.Add(t.T_name + ";" + t.H_id);
                comboBox3.Items.Add(t.T_name);
                //cBTiernameEX.Items.Add(t.T_name);
            }


        }
        private void Fotoanzeigen(int index)
        {
            string dateiname = "Images\\" + lit[index].T_name + ".jpg";


            if (File.Exists(dateiname))
            {
                pictureBox1.Image = Image.FromFile(dateiname);

            }
            else pictureBox1.Image = null;
        }
        private void fuergridAnzeigen()
        {



            lifg = db.getvgrid();


            dataGridView1.Rows.Clear();


            foreach (vfuergrid vfg in lifg)
            {
                dataGridView1.Rows.Add(vfg.Gname, vfg.Kname, vfg.Tname);

            }



        }
        private void FutterAnzeigen()
        {
            lBFutter.Items.Clear();
            comboBox2.Items.Clear();

            lifu = db.getFutter();


            foreach (Futter f in lifu)
            {
                lBFutter.Items.Add(f.Bezeichnung + "; " + f.Verpackung);
                comboBox2.Items.Add(f.Bezeichnung + "; " + f.Verpackung);
            }


        }
        private void TierfutterAnzeigen()
        {
           
            lBTierFutter.Items.Clear();
            litiefu = db.getTierFutter();
            

            foreach (Tierfutter tf in litiefu)
            {
                int index = lit.FindIndex(x => x.T_id== tf.T_id);
                int index1 = lifu.FindIndex(x => x.F_id == tf.F_id);
              
                lBTierFutter.Items.Add(lit[index].T_name + "-" + lifu[index1].Bezeichnung + "-" + tf.Menge);

            }

        }
        private void PflegerAnzeigen()
        {
            lBPfleger.Items.Clear();
            comboBox4.Items.Clear();

            lipf = db.getPfleger();


            foreach (Pfleger p in lipf)
            {
                lBPfleger.Items.Add(p.Nachname +" - "+ p.Vorname);
                comboBox4.Items.Add(p.Nachname + " - " + p.Vorname);
            }


        }
        private void SchichtplanAnzeigen()
        {

            lBSchichtplan.Items.Clear();
            lisch = db.getSchichtplan();
            

            foreach (Schichtplan sch in lisch)
            {
                int index = lige.FindIndex(x => x.G_id == sch.Gh_id);
                int index1 = lipf.FindIndex(x => x.P_id == sch.P_id);

                lBSchichtplan.Items.Add(lige[index].Name + "-" + lipf[index1].Nachname + "-" + lipf[index1].Vorname +sch.Schicht+sch.Rolle);

            }

        }



        // Selected Index von ListBoxen
        private void lBTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBTiere.SelectedIndex != -1)
            {
                Tier t = lit[lBTiere.SelectedIndex];

                tBTierID.Text = t.T_id.ToString();
                tBTierName.Text = t.T_name;
                dateTimePicker1.Text = t.Gebdat;
                cBHerkunftTier.Text = t.H_id.ToString();
                cBTierartTier.Text = t.T_id.ToString();
                cBGehegeTier.Text = t.Gh_id.ToString();


                cBHerkunftTier.SelectedIndex =
                    lih.FindIndex(x => x.H_id == t.H_id);
                cBTierartTier.SelectedIndex =
                    lita.FindIndex(x => x.Ta_id == t.Ta_id);
                cBGehegeTier.SelectedIndex =
                    lige.FindIndex(x => x.G_id == t.Gh_id);

                Fotoanzeigen(lBTiere.SelectedIndex);

            }

        }
        private void lBArten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBArten.SelectedIndex != -1)
            {
                Tierart ta = lita[lBArten.SelectedIndex];

                tBTierartID.Text = ta.Ta_id.ToString();
                tBTierartBezeichnung.Text = ta.Bezeichnung;

            }
        }
        private void lBFutter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lBFutter.SelectedIndex != -1)
            {
                Futter f = lifu[lBFutter.SelectedIndex];

                textBox3.Text = f.F_id.ToString();
                textBox2.Text = f.Bezeichnung;
                textBox2.Text = f.Verpackung;

            }
        }
        private void lBTierFutter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBTierFutter.SelectedIndex != -1)
            {
                Tierfutter tf = litiefu[lBTierFutter.SelectedIndex];

                comboBox3.Text = tf.T_id.ToString();
                comboBox2.Text = tf.F_id.ToString();
                textBox1.Text = tf.Menge;

            }
        }
        private void lBPfleger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBPfleger.SelectedIndex != -1)
            {
                Pfleger p = lipf[lBPfleger.SelectedIndex];

                tBPflegerID.Text = p.P_id.ToString();
                tBPfelgerNachnme.Text = p.Nachname;
                tBPflegerVorname.Text = p.Vorname;

            }
        }
        private void lBSchichtplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBSchichtplan.SelectedIndex != -1)
            {
                comboBox4.SelectedIndex = lipf.FindIndex(x => x.P_id == lisch[lBSchichtplan.SelectedIndex].P_id);
                cBSchichtGehege.SelectedIndex = lige.FindIndex(x => x.G_id == lisch[lBSchichtplan.SelectedIndex].Gh_id);

                rBChef.Checked = lisch[lBSchichtplan.SelectedIndex].Rolle;
                rBAssi.Checked = !rBChef.Checked;
                rBVormittag.Checked = lisch[lBSchichtplan.SelectedIndex].Schicht;
                rBNachmittag.Checked = !rBVormittag.Checked;
            }
            
        }


        //Speichern Button
        private void btnTierSpeichern_Click(object sender, EventArgs e)
        {
            Tier t = new Tier();

            t.T_id = -1;
            t.T_name = tBTierName.Text;
            t.Gebdat = dateTimePicker1.Text;
            t.H_id = lih[cBHerkunftTier.SelectedIndex].H_id;
            t.Ta_id = lita[cBTierartTier.SelectedIndex].Ta_id;
            t.Gh_id = lige[cBGehegeTier.SelectedIndex].G_id;

            db.saveTier(t);
            TierAnzeigen();
            fuergridAnzeigen();
            clearFieldsTiere();

        }
        private void btnSpeichernTierart_Click(object sender, EventArgs e)
        {
            cBTierartTier.Items.Clear();
            Tierart ta = new Tierart();


            ta.Ta_id = -1;
            ta.Bezeichnung = tBTierartBezeichnung.Text;


            db.saveTierart(ta);
            TierartAnzeigen();
            clearTierart();

        }
        private void btnSaveTieFU_Click(object sender, EventArgs e)
        {
            Tierfutter tf = new Tierfutter();



            tf.Menge = textBox1.Text;
            tf.T_id = lit[comboBox3.SelectedIndex].T_id;
            tf.F_id = lifu[comboBox2.SelectedIndex].F_id;

            db.saveTierfutter(tf);
            TierfutterAnzeigen();

        }
        private void btnSaveFu_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Futter f = new Futter();


            f.F_id = -1;
            f.Bezeichnung = textBox2.Text;
            f.Verpackung = tBVerpackung.Text;


            db.saveFutter(f);
            FutterAnzeigen();

        }
        private void btnSavePfleger_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            Pfleger p = new Pfleger();


            p.P_id = -1;
            p.Nachname = tBPfelgerNachnme.Text;
            p.Vorname = tBPflegerVorname.Text;


            db.savePfleger(p);
            PflegerAnzeigen();

        }
        private void btnSpeicherSchicht_Click(object sender, EventArgs e)
        {

            Schichtplan sch = new Schichtplan();

            sch.P_id = lipf[comboBox4.SelectedIndex].P_id;
            sch.Gh_id = lige[cBSchichtGehege.SelectedIndex].G_id;

            sch.Rolle = rBChef.Checked;
            sch.Schicht = rBVormittag.Checked;



            db.saveSchichtplan(sch);
            SchichtplanAnzeigen();
        }


        //Löschen Button
        private void btnLöschenTier_Click(object sender, EventArgs e)
        {
            if (lBTiere.SelectedIndex != -1)
            {
                db.delTier(Convert.ToInt32(tBTierID.Text));
                TierAnzeigen();
            }
            fuergridAnzeigen();
            clearFieldsTiere();
        }
        private void btnDeleteTierart_Click(object sender, EventArgs e)
        {
            if (lBArten.SelectedIndex != -1)
            {
                db.delGehege(Convert.ToInt32(tBTierartID.Text));
                TierartAnzeigen();
            }
            clearTierart();
        }
        private void btnDelTieFU_Click(object sender, EventArgs e)
        {
            if (lBTierFutter.SelectedIndex != -1)
            {
                db.delTierfutter(Convert.ToInt32(comboBox3.Text), Convert.ToInt32(comboBox2.Text));
                TierfutterAnzeigen();
            }


        }
        private void btnDelFU_Click(object sender, EventArgs e)
        {
            if (lBFutter.SelectedIndex != -1)
            {
                db.delFutter(Convert.ToInt32(textBox3.Text));

            }
            FutterAnzeigen();


        }
        private void btnDeletePfleger_Click(object sender, EventArgs e)
        {
            if (lBPfleger.SelectedIndex != -1)
            {
                db.delPfleger(Convert.ToInt32(tBPflegerID.Text));

            }
            PflegerAnzeigen();
        }
        private void btnLöscheSchicht_Click(object sender, EventArgs e)
        {

            if (lBSchichtplan.SelectedIndex != -1)
            {
                db.delSchichtplan(Convert.ToInt32(comboBox4.Text), Convert.ToInt32(cBSchichtGehege.Text));
                SchichtplanAnzeigen();
            }

        }


        //Update Button
        private void btnUpdateTier_Click(object sender, EventArgs e)
        {
            Tier t = new Tier();

            t.T_id = Convert.ToInt32(tBTierID.Text);
            t.T_name = tBTierName.Text;
            t.Gebdat = dateTimePicker1.Text;
            t.H_id = lit[cBHerkunftTier.SelectedIndex].H_id;
            t.Ta_id = lita[cBTierartTier.SelectedIndex].Ta_id;
            t.Gh_id = lige[cBGehegeTier.SelectedIndex].G_id;

            db.updateTier(t);
            TierAnzeigen();
            fuergridAnzeigen();
            clearFieldsTiere();
        }
        private void btnUpdateTierart_Click(object sender, EventArgs e)
        {
            Tierart ta = new Tierart();

            ta.Ta_id = Convert.ToInt32(tBTierartID.Text);
            ta.Bezeichnung = tBTierartBezeichnung.Text;


            db.updateTierart(ta);
            TierartAnzeigen();
            clearTierart();
        }
        private void btnUpdateTieFU_Click(object sender, EventArgs e)
        {
            Tierfutter tf = new Tierfutter();


            tf.Menge = textBox1.Text;
            tf.T_id = lit[comboBox3.SelectedIndex].T_id;
            tf.F_id = lifu[comboBox2.SelectedIndex].F_id;


            db.updateTierfutter(tf);
            TierfutterAnzeigen();


        }
        private void btnUpdateFu_Click(object sender, EventArgs e)
        {
            Futter f = new Futter();

            f.F_id = Convert.ToInt32(textBox3.Text);
            f.Bezeichnung = textBox2.Text;
            f.Verpackung = tBVerpackung.Text;


            db.updateFutter(f);
            FutterAnzeigen();

        }
        private void btnUpdatePfleger_Click(object sender, EventArgs e)
        {
            Pfleger p = new Pfleger();

            p.P_id = Convert.ToInt32(tBPflegerID.Text);
            p.Nachname = tBPfelgerNachnme.Text;
            p.Vorname = tBPflegerVorname.Text;


            db.updatePfleger(p);
            PflegerAnzeigen();

        }
        private void btnUpdateSchicht_Click(object sender, EventArgs e)
        {
            Schichtplan sch = new Schichtplan();


            sch.P_id = lit[comboBox4.SelectedIndex].T_id;
            sch.Gh_id = lifu[cBSchichtGehege.SelectedIndex].F_id;

            sch.Rolle = rBChef.Checked;
            sch.Schicht = rBVormittag.Checked;

            db.saveSchichtplan(sch);
            SchichtplanAnzeigen();
        }


        //Foto Hochladen
        private void btnFoto_Click(object sender, EventArgs e)
        {
            string filePath;
            string savepath = "Images\\";
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "c:\\";
            opf.Filter = "jpg files (*.jpg)|*.jpg;";
            opf.FilterIndex = 2;
            opf.RestoreDirectory = true;

            if (opf.ShowDialog() == DialogResult.OK)
            {

                filePath = opf.FileName;
                savepath += (tBTierName.Text + ".jpg");

                File.Copy(filePath, savepath);

                pictureBox1.Image = Image.FromFile(savepath);

            }
        }


        // Label Click
        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tiersuche TS = new Tiersuche();
            TS.ShowDialog();
            this.Show();
        }
        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Themen_und_Gehege TG = new Themen_und_Gehege();
            TG.ShowDialog();
            this.Show();
            GehegeAnzeigen();

        }


        //Mouse Hover 
        private void label15_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label15.ForeColor = Color.Red;
        }
        private void label16_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label16.ForeColor = Color.Red;
        }


        //Mouse Leave 
        private void label16_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label16.ForeColor = Color.Blue;
        }
        private void label15_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label15.ForeColor = Color.Blue;
        }


        //Button XML Liste erstellen
        private void btntlerstellen_Click(object sender, EventArgs e)
        {

            XmlWriter writer = XmlWriter.Create("Tiere.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Tiere");

            foreach (Tier t in lit)
            {
                writer.WriteStartElement("Tiere");
                writer.WriteAttributeString("T_ID", t.T_id.ToString());
                writer.WriteAttributeString("Gebdat", t.Gebdat.ToString());
                writer.WriteAttributeString("TA_ID", t.Ta_id.ToString());
                writer.WriteAttributeString("GH_ID", t.Gh_id.ToString());
                writer.WriteAttributeString("H_ID", t.H_id.ToString());
                writer.WriteAttributeString("Name", t.T_name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
        private void btnTALi_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Tierart.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Tierart");

            foreach (Tierart ta in lita)
            {
                writer.WriteStartElement("Tierart");
                writer.WriteAttributeString("TA_ID", ta.Ta_id.ToString());
                writer.WriteAttributeString("Bezeichnung", ta.Bezeichnung);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        private void btnTierfuLi_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Tierfutter.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Tierfutter");

            foreach (Tierfutter tf in litiefu)
            {
                writer.WriteStartElement("Tierfutter");
                writer.WriteAttributeString("t_id", tf.T_id.ToString());
                writer.WriteAttributeString("f_id", tf.F_id.ToString());
                writer.WriteAttributeString("menge", tf.Menge);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        private void btnFutterLierst_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Futter.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("Futter");

            foreach (Futter f in lifu)
            {
                writer.WriteStartElement("Futter");
                writer.WriteAttributeString("f_id", f.F_id.ToString());
                writer.WriteAttributeString("bezeichnung", f.Bezeichnung);
                writer.WriteAttributeString("verpackung", f.Verpackung);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
        private void btnFutterLiLe_Click(object sender, EventArgs e)
        {
            try
            {

                reader = new XmlTextReader("Futter.xml");

                while (reader.Read())
                {


                    if (reader.Name != "")
                    {

                        if (reader.Name == "Futter")
                        {


                            if (reader.AttributeCount == 3)
                            {
                                Futter f = new Futter();

                                reader.MoveToAttribute("f_id");
                                f.F_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("bezeichnung");
                                f.Bezeichnung = reader.Value;


                                reader.MoveToAttribute("verpackung");
                                f.Verpackung = reader.Value;

                                db.saveFutter(f);
                            }



                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Lesen. Bitte notieren. " + ex.Message);

            }
            finally
            {
                if (reader != null)
                    reader.Close();
                FutterAnzeigen();
            }
        }


        // XML Liste einlesn
        private void TierartLesen()
        {
            try
            {

                reader = new XmlTextReader("Tierart.xml");

                while (reader.Read())
                {


                    if (reader.Name != "")
                    {


                        if (reader.Name == "Tierart")
                        {


                            if (reader.AttributeCount == 2)
                            {
                                Tierart ta = new Tierart();

                                reader.MoveToAttribute("TA_ID");
                                ta.Ta_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("Bezeichnung");
                                ta.Bezeichnung = reader.Value;

                                db.saveTierart(ta);
                            }


                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Lesen. Bitte notieren. " + ex.Message);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

            }
        }
        private void TierLesen()
        {
            try
            {

                reader = new XmlTextReader("Tiere.xml");

                while (reader.Read())
                {


                    if (reader.Name != "")
                    {

                        if (reader.Name == "Tiere")
                        {


                            if (reader.AttributeCount == 6)
                            {
                                Tier t = new Tier();

                                reader.MoveToAttribute("T_ID");
                                t.T_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("GebDat");
                                t.Gebdat = reader.Value;

                                reader.MoveToAttribute("TA_ID");
                                t.Ta_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("GH_ID");
                                t.Gh_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("H_ID");
                                t.H_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("Name");
                                t.T_name = reader.Value;

                                db.saveTier(t);
                            }



                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Lesen. Bitte notieren. " + ex.Message);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

            }
        }


        // Knopf zum einlesen
        private void btnTaLiLe_Click(object sender, EventArgs e)
        {
            TierartLesen();

        }
        private void btnTierlesen_Click(object sender, EventArgs e)
        {
            TierLesen();
        }
        private void btnTiefuLiLe_Click(object sender, EventArgs e)
        {
            try
            {

                reader = new XmlTextReader("Tierfutter.xml");

                while (reader.Read())
                {


                    if (reader.Name != "")
                    {

                        if (reader.Name == "Tierfutter")
                        {


                            if (reader.AttributeCount == 3)
                            {
                                Tierfutter tf = new Tierfutter();

                                reader.MoveToAttribute("t_id");
                                tf.T_id = Convert.ToInt32(reader.Value);


                                reader.MoveToAttribute("f_id");
                                tf.F_id = Convert.ToInt32(reader.Value);

                                reader.MoveToAttribute("menge");
                                tf.Menge = reader.Value;

                                db.saveTierfutter(tf);
                            }



                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Lesen. Bitte notieren. " + ex.Message);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                TierfutterAnzeigen();
            }
        }


        // PDF Erstellen
        private void btnPDF_Click(object sender, EventArgs e)
        { 
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Create an empty page
            PdfPage page = document.AddPage();
            //page.Contents.CreateSingleContent().Stream.UnfilteredValue;

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // Create a font
            XFont font = new XFont("Arial", 12, XFontStyle.Bold, options);

            // Draw the text
            int myY = 40;

            foreach (Tierfutter tf in litiefu)
            {
                XRect rect = new XRect(40, myY, 250, 60);
                int index = lit.FindIndex(x => x.T_id == tf.T_id);
                int index1 = lifu.FindIndex(y => y.F_id == tf.F_id);
                gfx.DrawString(lit[index].T_name + ": " + lifu[index1].Bezeichnung + "-" + tf.Menge, font, XBrushes.Black,
            rect,
            XStringFormats.BottomLeft);// stelle an die geschrieben wird
                myY += 40;

            }
            // Save the document...
            string filename = "Tierfutter.pdf";
            document.Save(filename);
            // ...and start a viewer.
          
        }
        private void btnPDFSchicht_Click(object sender, EventArgs e)
        {

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
            XFont font = new XFont("Arial", 12, XFontStyle.Bold, options);

            int myY = 40;

            foreach (Schichtplan sch in lisch)
            {
                XRect rect = new XRect(40, myY, 250, 60);
                int index = lige.FindIndex(x => x.G_id == sch.Gh_id);
                int index1 = lipf.FindIndex(x => x.P_id == sch.P_id);
                gfx.DrawString("Ort: "+lige[index].Name + " - " +"Wer: "+ lipf[index1].Nachname + "," + lipf[index1].Vorname +
                    " - " +"Schicht am Vormittag:" + sch.Schicht +" - "+"Chef-Pfleger: "  + sch.Rolle, font, XBrushes.Black,
            rect,
            XStringFormats.BottomLeft);
                myY += 40;

            }
         
            string filename = "Schichtplan.pdf";
            document.Save(filename);
            
        }



        private void ExcelEintragen(string fn)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application excel =
                    new Microsoft.Office.Interop.Excel.Application();

                excel.Visible = true;

                // Arbeitsmappe öffnen, muss vhd. sein
                string fileName = fn;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Open(fileName);

                // Arbeitsblatt  referenzieren
                // Tabelle öffnen
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets["Tierart"];

                // Erster Eintrag, Bereich markieren
                Microsoft.Office.Interop.Excel.Range bRange = worksheet.get_Range("B2:B2");
                bRange.Value = textBox1.Text;

                // Zelleneinstellungen
                bRange.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red);
                bRange.Borders.Weight = 3;
                bRange.Cells.Borders.LineStyle =Microsoft.Office.Interop.Excel.XlLineStyle.xlSlantDashDot;
                bRange.Borders.Color = Color.Black.ToArgb();

                // Zweiter Eintrag, neuer Bereich
                bRange = worksheet.get_Range("B3:B3");
                bRange.Value = textBox2.Text;

                // Dritter Eintrag, neuer Bereich
                bRange = worksheet.get_Range("B4:B4");
                bRange.Value = textBox3.Text;

                // Arbeitsmappe speichern
                workbook.Save();

                // Excel beenden
                excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelEintragen(@"E:\C#Programme\Zoo\Zoo\bin\Debug\net6.0-windows\Tierart.xlsx");
        }

        private void btnExcelMappe_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application excel =
                    new Microsoft.Office.Interop.Excel.Application();

                excel.Visible = true;

                // Arbeitsmappe öffnen
                string fileName = (@"E:\C#Programme\Zoo\Zoo\bin\Debug\net6.0-windows\Tierart.xlsx");
                Microsoft.Office.Interop.Excel.Workbook workbook;

                // Mappe anlegen
                workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                //// Tabelle anlegen
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Worksheet)workbook.Worksheets[1];

                //// ueberschreiben ohne Nachfrage. wenn Arbeitsmappe vhd.
                excel.DisplayAlerts = false;
                worksheet.Name = DateTime.Now.ToShortDateString();

                // Erster Eintrag, neuer Bereich
                Microsoft.Office.Interop.Excel.Range bRange = worksheet.get_Range("B2:B2");
                bRange.Value = lBArten.Text;

                // Zelleneinstellungen
                bRange.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red);
                bRange.Borders.Weight = 3;
                bRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlSlantDashDot;
                bRange.Borders.Color = Color.Black.ToArgb();

               /* // Zweiter Eintrag, neuer Bereich
                bRange = worksheet.get_Range("B3:B3");
                bRange.Value = textBox2.Text;

                // Dritter Eintrag, neuer Bereich
                bRange = worksheet.get_Range("B4:B4");
                bRange.Value = textBox3.Text;*/

                // Neues Workbook speichern
                workbook.SaveAs(fileName);

                workbook.Close();

                // Excel beenden
                excel.Application.Quit();
                excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rBChef_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}