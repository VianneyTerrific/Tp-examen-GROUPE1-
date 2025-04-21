using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_GL_Groupe01._1._Classes
{
    internal class Adresse
    {
        public string Id { get; set; }
        public string Quartier { get; set; }
        public string Commune { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }

        DataAccess data = new DataAccess();

        public int Enregistrer(Adresse adresse)
        {
            int resultat = 0;
            string strQuery = "sp_AjouterAdresse";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", adresse.Id);
                cmd.Parameters.AddWithValue("@quartier", adresse.Quartier);
                cmd.Parameters.AddWithValue("@commune", adresse.Commune);
                cmd.Parameters.AddWithValue("@ville", adresse.Ville);
                cmd.Parameters.AddWithValue("@pays", adresse.Pays);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }

            return resultat;
        }

        public int Modifier(Adresse adresse)
        {
            int resultat = 0;
            string strQuery = "sp_ModifierAdresse";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", adresse.Id);
                cmd.Parameters.AddWithValue("@quartier", adresse.Quartier);
                cmd.Parameters.AddWithValue("@commune", adresse.Commune);
                cmd.Parameters.AddWithValue("@ville", adresse.Ville);
                cmd.Parameters.AddWithValue("@pays", adresse.Pays);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer(Adresse adresse)
        {
            int resultat = 0;
            string strQuery = "sp_SupprimerAdresse";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", adresse.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer2(Adresse adresse)
        {
            int resultat = 0;
            string strQuery = "delete from domicile where id_adresse=@id_adresse";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.Parameters.AddWithValue("@id_adresse", adresse.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public List<Adresse> GetAdresse()
        {
            List<Adresse> list = new List<Adresse>();
            string strQuery = "sp_AfficherAdresse";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Adresse adresse = new Adresse();
                    adresse.Id = rd["id"].ToString();
                    adresse.Quartier = rd["quartier"].ToString();
                    adresse.Commune = rd["commune"].ToString();
                    adresse.Ville = rd["ville"].ToString();
                    adresse.Pays = rd["pays"].ToString();
                    list.Add(adresse);
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }
    }
}
