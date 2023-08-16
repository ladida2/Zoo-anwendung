using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Zoo
{
    public class Datenbank
    {
        private MySqlConnection con = null;

        public Datenbank()
        {
            con = new MySqlConnection("SERVER = localhost;UID = root; PASSWORD = '';DATABASE = zoo");
        }

        // DAtenbank Funktionen
        private void oeffnen()
        {

            con.Open();
        }
        private void schliessen()
        {
            if (con != null)
                con.Close();
        }


        //Listen 
        public List<Gehege> getGehege()
        {
            List<Gehege> lige = new List<Gehege>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from gehege;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lige.Add(
                    new Gehege(reader.GetInt32(0)               
                                   , reader.GetString(1)               
                                   , reader.GetDouble(2)
                                   , reader.GetInt32(3))               
                    );
            }
            schliessen();
            return lige;
        }
        public List<Kontinente> getkontinente()
        {
            List<Kontinente> liko = new List<Kontinente>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from kontinente;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                liko.Add(
                    new Kontinente(reader.GetInt32(0)
                             , reader.GetString(1)
                                   )
                    );
            }
            schliessen();
            return liko;
        }
        public List<Tierart> getArten()
        {
            List<Tierart> lita = new List<Tierart>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from Tierart;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lita.Add(
                    new Tierart(reader.GetInt32(0)
                             , reader.GetString(1)
                                   )
                    );
            }
            schliessen();
            return lita;
        }
        public List<Tier> getTier()
        {
            List<Tier> lit = new List<Tier>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from tiere;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lit.Add(
                    new Tier(reader.GetInt32(0)
                                   , reader.GetDateTime(1).ToString()
                                   , reader.GetInt32(2)
                                   , reader.GetInt32(3)
                                   , reader.GetInt32(4)
                                   , reader.GetString(5))
                    );
            }
            schliessen();
            return lit;
        }
        public List<Tier> getTier1()
        {
            List<Tier> lit1 = new List<Tier>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from tiere;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lit1.Add(
                    new Tier(reader.GetInt32(0)
                                   , reader.GetDateTime(2).ToString()
                                   , reader.GetInt32(3)
                                   , reader.GetInt32(4)
                                   , reader.GetInt32(5)
                                    , reader.GetString(1))
                    );
            }
            schliessen();
            return lit1;
        }
        public List<Herkunft> getHerkunft()
        {
            List<Herkunft> lih = new List<Herkunft>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from herkunft;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lih.Add(
                    new Herkunft(reader.GetInt32(0)
                             , reader.GetString(1)
                                   )
                    );
            }
            schliessen();
            return lih;
        }
        public List<vgehtier> getgehtier()
        {
            List<vgehtier> ligt = new List<vgehtier>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from vgehtier;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ligt.Add(
                    new vgehtier(reader.GetString(0)
                             , reader.GetString(1)
                                   )
                    );
            }
            schliessen();
            return ligt;
        }
        public List<vkonge> getkonge()
        {
            List<vkonge> likg = new List<vkonge>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from vkonge;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                likg.Add(
                    new vkonge(reader.GetString(0)
                             , reader.GetString(1)
                                   )
                    );
            }
            schliessen();
            return likg;
        }
        public List<vfuergrid> getvgrid()
        {
            List<vfuergrid> lifg = new List<vfuergrid>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from vfuergrid order by kname;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lifg.Add(
                    new vfuergrid(reader.GetString(0)
                             , reader.GetString(1)
                              , reader.GetString(2)
                                   )
                    );
            }
            schliessen();
            return lifg;
        }
        public List<Tier> getsucheTier(string suche)
        {

            List<Tier> lit = new List<Tier>();

            oeffnen();

            string s = string.Format
                (" select * from tiere where name like '%{0}%';", suche);

            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                lit.Add(

                   new Tier(reader.GetInt32(0)
                                   , reader.GetDateTime(1).ToString()
                                   , reader.GetInt32(2)
                                   , reader.GetInt32(3)
                                   , reader.GetInt32(4)
                                    , reader.GetString(5))
                    );
            }

            reader.Close();
            schliessen();
            return lit;
        }
        public List<Futter> getFutter()
        {
            List<Futter> lifu = new List<Futter>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from futter;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lifu.Add(
                    new Futter(reader.GetInt32(0)
                             , reader.GetString(1)
                             , reader.GetString(2)
                                   )
                    );
            }
            schliessen();
            return lifu;
        }
        public List<Tierfutter> getTierFutter()
        {
            List<Tierfutter> litiefu = new List<Tierfutter>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from tierfutter;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                litiefu.Add(
                    new Tierfutter(reader.GetInt32(0)
                               , reader.GetInt32(1)
                             , reader.GetString(2)
                                   )
                    );
            }
            schliessen();
            return litiefu;
        }
        public List<Pfleger> getPfleger()

        {
            List<Pfleger> lipf = new List<Pfleger>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from pfleger;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lipf.Add(
                    new Pfleger(reader.GetInt32(0)
                             , reader.GetString(1)
                             , reader.GetString(2)
                                   )
                    );
            }
            schliessen();
            return lipf;
        }
        public List<Schichtplan> getSchichtplan()
        {
            List<Schichtplan> lisch = new List<Schichtplan>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Select * from schichtplan;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                lisch.Add(
                    new Schichtplan(reader.GetInt32(0)
                               , reader.GetInt32(1)
                             , reader.GetBoolean(2)
                             , reader.GetBoolean(3)
                                   )
                    );
            }
            schliessen();
            return lisch;
        }

        // Speichern Funktionen
        public void saveGehege(Gehege ge)
        {
            oeffnen();
            string s = String.Format("Insert into gehege Values(null,'{0}',{1},'{2}');",
                                       ge.Name, ge.Groesse, ge.K_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void saveTierart(Tierart ta)
        {
            oeffnen();
            string s = String.Format("Insert into tierart Values(null,'{0}');",
                                        ta.Bezeichnung);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void saveTier(Tier t)
        {
            oeffnen();

            string[] help = t.Gebdat.Split('.');
            string hilf = help[2] + "-" + help[1] + "-" + help[0];

            string s = String.Format("Insert into tiere Values(null,'{0}','{1}',{2},{3},'{4}');",
                                         hilf, t.Ta_id, t.Gh_id, t.H_id, t.T_name);

            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void saveFutter(Futter f)
        {
            oeffnen();
            string s = String.Format("Insert into Futter Values(null,'{0}','{1}');",
                                        f.Bezeichnung, f.Verpackung);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void saveTierfutter(Tierfutter tf)
        {
            oeffnen();
            string s = String.Format("Insert into tierfutter Values( '{0}','{1}','{2}');",
                                        tf.T_id, tf.F_id, tf.Menge);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void savePfleger(Pfleger p)
        {
            oeffnen();
            string s = String.Format("Insert into Pfleger Values(null,'{0}','{1}');",
                                        p.Nachname, p.Vorname);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void saveSchichtplan(Schichtplan sch)
        {
            oeffnen();
            string s = String.Format("Insert into schichtplan Values( '{0}','{1}',{2},{3});",
                                        sch.P_id, sch.Gh_id, sch.Rolle, sch.Schicht);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delGehege(int gid)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From Schichtplan where gh_id = " + gid.ToString() + ";";
            com.ExecuteNonQuery();


            com.CommandText = "Delete From gehege where gh_id = " + gid.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }

        //Löschen Funktion
        public void delTierart(int taid)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From gehege where ta_id = " + taid.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delTier(int tid)
        {


            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From tierfutter where t_id = " + tid.ToString() + ";";
            com.ExecuteNonQuery();


            com.CommandText = "Delete From tiere where t_id = " + tid.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delFutter(int f_id)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From tierfutter where f_id = " + f_id.ToString() + ";";
            com.ExecuteNonQuery();




            com.CommandText = "Delete From futter where f_id = " + f_id.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delTierfutter(int f_id, int t_id)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From tierfutter where f_id = " + f_id.ToString() + " and t_id =" + t_id.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delPfleger(int p_id)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From Schichtplan where p_id = " + p_id.ToString() + ";";
            com.ExecuteNonQuery();




            com.CommandText = "Delete From pfleger where p_id = " + p_id.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        public void delSchichtplan(int p_id, int gh_id)
        {
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "Delete From schichtplan where p_id = " + p_id.ToString() + " and gh_id =" + gh_id.ToString() + ";";
            com.ExecuteNonQuery();

            schliessen();
        }

        // Update Funktionen
        public void updateGehege(Gehege ge)
        {
            oeffnen();

            string s = String.Format("Update gehege Set groesse='{0}', K_ID={1},Name='{2}' where GH_id = {3};",
                                       ge.Groesse, ge.K_id, ge.Name, ge.G_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();


        }
        public void updateTierart(Tierart ta)
        {
            oeffnen();

            string s = String.Format("Update tierart Set bezeichnung='{0}' where ta_id = {1};",
                                       ta.Bezeichnung,ta.Ta_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();

        }
        public void updateTier(Tier t)
        {
            oeffnen();

            string[] help = t.Gebdat.Split('.');
            string hilf = help[2] + "-" + help[1] + "-" + help[0];

            string s = String.Format("Update tiere Set Name='{0}', Gebdat='{1}',ta_id='{2}',gh_id={3}, h_id ={4} where t_id = {5};",
                                        t.T_name, hilf, t.Ta_id, t.Gh_id,t.H_id,t.T_id);

            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();


        }
        public void updateFutter(Futter f)
        {
            oeffnen();

            string s = String.Format("Update futter Set bezeichnung='{0}', verpackung ='{1}' where f_id = {2};",
                                       f.Bezeichnung,f.Verpackung, f.F_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();

        }
        public void updateTierfutter(Tierfutter tf)
        {
            oeffnen();

            string s = String.Format("Update tierart Set menge='{0}' where ta_id = {1} and f_id = {2};",
                                       tf.Menge, tf.T_id,tf.F_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();

        }
        public void updatePfleger(Pfleger p)
        {
            oeffnen();

            string s = String.Format("Update pfleger Set nachname='{0}', vorname ='{1}' where p_id = {2};",
                                       p.Nachname, p.Nachname, p.P_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();

        }
        public void updateSchichtplan(Schichtplan sch)
        {
            oeffnen();

            string s = String.Format("Update tierart Set rolle='{0}' ,schicht='{1}' where p_id = {2} and gh_id = {3};",
                                      sch.Rolle, sch.Schicht,sch.P_id, sch.Gh_id);
            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();

        }

    }
}
