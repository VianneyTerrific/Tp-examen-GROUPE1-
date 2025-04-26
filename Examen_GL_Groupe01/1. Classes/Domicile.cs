using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_GL_Groupe01._4._Connexion;

namespace Examen_GL_Groupe01._1._Classes
{
    internal class Domicile
    {
        public string Id { get; set; }
        public string IdPersonne { get; set; }
        public string Noms { get; set; }
        public string IdAdresse { get; set; }
        public string Adresse { get; set; }
        public string Avenue { get; set; }
        public string NumeroAvenue { get; set; }

        DataAccess data = new DataAccess();

        public int Enregistrer(Domicile domicile)
        {
            int resultat = 0;
            string strQuery = "sp_AjouterDomicile";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", domicile.Id);
                cmd.Parameters.AddWithValue("@id_personne", domicile.IdPersonne);
                cmd.Parameters.AddWithValue("@id_adresse", domicile.IdAdresse);
                cmd.Parameters.AddWithValue("@avenue", domicile.Avenue);
                cmd.Parameters.AddWithValue("@numero_avenue", domicile.NumeroAvenue);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }

            return resultat;
        }

        public int Modifier(Domicile domicile)
        {
            int resultat = 0;
            string strQuery = "sp_ModifierDomicile";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", domicile.Id);
                cmd.Parameters.AddWithValue("@id_personne", domicile.IdPersonne);
                cmd.Parameters.AddWithValue("@id_adresse", domicile.IdAdresse);
                cmd.Parameters.AddWithValue("@avenue", domicile.Avenue);
                cmd.Parameters.AddWithValue("@numero_avenue", domicile.NumeroAvenue);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer(Domicile domicile)
        {
            int resultat = 0;
            string strQuery = "sp_SupprimerDomicile";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", domicile.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public List<Domicile> GetDomicile()
        {
            List<Domicile> list = new List<Domicile>();
            string strQuery = "sp_AfficherDomicile";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Domicile domicile = new Domicile();
                    domicile.Id = rd["id"].ToString();
                    domicile.IdPersonne = rd["id_personne"].ToString();
                    domicile.Noms = rd["noms"].ToString();
                    domicile.IdAdresse = rd["id_adresse"].ToString();
                    domicile.Adresse = rd["adresse"].ToString();
                    domicile.Avenue = rd["avenue"].ToString();
                    domicile.NumeroAvenue = rd["numero_avenue"].ToString();
                    list.Add(domicile);
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }
    }
}
